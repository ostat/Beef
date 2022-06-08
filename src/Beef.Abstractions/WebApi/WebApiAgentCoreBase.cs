﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using Beef.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Beef.WebApi
{
    /// <summary>
    /// Provides the core capabilites to <b>invoke</b> API agent operations.
    /// </summary>
    public abstract class WebApiAgentCoreBase
    {
        /// <summary>
        /// Sets the accept header for the <paramref name="httpClient"/> to <see cref="MediaTypeNames.Application.Json"/>. 
        /// </summary>
        /// <param name="httpClient">The <see cref="System.Net.Http.HttpClient"/>.</param>
        public static void SetAcceptApplicationJson(HttpClient httpClient)
        {
            if (httpClient == null)
                throw new ArgumentNullException(nameof(httpClient));

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiAgentCoreBase"/> class.
        /// </summary>
        /// <param name="args">The <see cref="IWebApiAgentArgs"/>.</param>
        protected WebApiAgentCoreBase(IWebApiAgentArgs args) => Args = args ?? throw new ArgumentNullException(nameof(args));

        /// <summary>
        /// Gets the <see cref="IWebApiAgentArgs"/>.
        /// </summary>
        public IWebApiAgentArgs Args { get; private set; }

        /// <summary>
        /// Creates the <see cref="HttpRequestMessage"/> and invokes the <see cref="IWebApiAgentArgs.BeforeRequest"/>.
        /// </summary>
        /// <param name="method">The <see cref="HttpMethod"/>.</param>
        /// <param name="uri">The <see cref="Uri"/>.</param>
        /// <param name="content">The optional <see cref="StringContent"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        protected async Task<HttpRequestMessage> CreateRequestMessageAsync(HttpMethod method, Uri uri, StringContent? content = null, WebApiRequestOptions? requestOptions = null)
        {
            var req = new HttpRequestMessage(method, uri);
            if (content != null)
                req.Content = content;

            if (ExecutionContext.HasCurrent && !string.IsNullOrEmpty(ExecutionContext.Current.CorrelationId))
                req.Headers.Add(WebApiConsts.CorrelationIdHeaderName, ExecutionContext.Current.CorrelationId);

            ApplyWebApiOptions(req, requestOptions);

            Args.BeforeRequest?.Invoke(req);
            await (Args.BeforeRequestAsync?.Invoke(req) ?? Task.CompletedTask).ConfigureAwait(false);
            return req;
        }

        /// <summary>
        /// Applys the <see cref="WebApiRequestOptions"/> to the<see cref="HttpRequestMessage"/>.
        /// </summary>
        private static void ApplyWebApiOptions(HttpRequestMessage request, WebApiRequestOptions? requestOptions = null)
        {
            if (requestOptions == null || string.IsNullOrEmpty(requestOptions.ETag))
                return;

            var etag = requestOptions.ETag.StartsWith("\"", StringComparison.InvariantCultureIgnoreCase) && requestOptions.ETag.EndsWith("\"", StringComparison.InvariantCultureIgnoreCase) ? requestOptions.ETag : "\"" + requestOptions.ETag + "\"";

            if (request.Method == HttpMethod.Get)
                request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue(etag));
            else
                request.Headers.IfMatch.Add(new EntityTagHeaderValue(etag));
        }

        /// <summary>
        /// Creates the full <see cref="Uri"/> from concatenating the <see cref="HttpClient.BaseAddress"/> and <paramref name="urlSuffix"/>.
        /// </summary>
        /// <param name="urlSuffix">The specific url suffix for the operation.</param>
        /// <param name="args">The operation arguments to be substituted within the <paramref name="urlSuffix"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        protected Uri CreateFullUri(string? urlSuffix = null, WebApiArg[]? args = null, WebApiRequestOptions? requestOptions = null)
        {
            // Concatenate the base and specific url strings to form the full Url.
            var fullUrl = new StringBuilder(Args.HttpClient.BaseAddress.AbsoluteUri);
            if (!string.IsNullOrEmpty(urlSuffix))
            {
                if (fullUrl[^1] != '/')
                    fullUrl.Append('/');

                fullUrl.Append((urlSuffix[0] == '/') ? urlSuffix[1..] : urlSuffix);
            }

            var urlTemplate = fullUrl.ToString();
            bool hasQueryString = urlTemplate.Contains('?', StringComparison.InvariantCulture);

            // Replace known url tokens with passed argument values.
            if (args != null)
            {
                if (args.Count(x => x.ArgType == WebApiArgType.FromBody) > 1)
                    throw new ArgumentException("Only a single argument can have an ArgType of FromBody.", nameof(args));

                foreach (var arg in args.Where(x => x.ArgType != WebApiArgType.FromBody))
                {
                    var argUrl = $"{{{arg.Name}}}";
                    if (urlTemplate.Contains(argUrl, StringComparison.Ordinal))
                    {
                        fullUrl.Replace(argUrl, arg.ToString());
                        arg.IsUsed = true;
                    }
                }

                foreach (var arg in args.Where(x => !x.IsDefault && x.ArgType != WebApiArgType.FromBody && !x.IsUsed))
                {
                    var uqs = arg.ToUrlQueryString();
                    if (!string.IsNullOrEmpty(uqs))
                        hasQueryString = AppendQueryString(fullUrl, hasQueryString, uqs);
                }
            }

            // Add any optional query string arguments.
            if (requestOptions != null)
            {
                if (requestOptions.IncludeFields.Any())
                {
                    hasQueryString = AppendQueryString(fullUrl, hasQueryString, WebApiRequestOptions.IncludeFieldsQueryStringName);
                    fullUrl.Append('=');
                    fullUrl.Append(string.Join(",", requestOptions.IncludeFields.Where(x => !string.IsNullOrEmpty(x))));
                }

                if (requestOptions.ExcludeFields.Any())
                {
                    hasQueryString = AppendQueryString(fullUrl, hasQueryString, WebApiRequestOptions.ExcludeFieldsQueryStringName);
                    fullUrl.Append('=');
                    fullUrl.Append(string.Join(",", requestOptions.ExcludeFields.Where(x => !string.IsNullOrEmpty(x))));
                }

                if (requestOptions.IncludeRefDataText)
                {
                    hasQueryString = AppendQueryString(fullUrl, hasQueryString, WebApiRequestOptions.IncludeRefDataTextQueryStringName);
                    fullUrl.Append("=true");
                }

                if (requestOptions.IncludeInactive)
                {
                    hasQueryString = AppendQueryString(fullUrl, hasQueryString, WebApiRequestOptions.IncludeInactiveQueryStringName);
                    fullUrl.Append("=true");
                }

                if (!string.IsNullOrEmpty(requestOptions.UrlQueryString))
                    hasQueryString = AppendQueryString(fullUrl, hasQueryString, (requestOptions.UrlQueryString[0] == '?' || requestOptions.UrlQueryString[0] == '&') ? requestOptions.UrlQueryString[1..] : requestOptions.UrlQueryString);
            }

            return new Uri(fullUrl.Replace(" ", "%20").ToString());
        }

        /// <summary>
        /// Appends the query to the query string.
        /// </summary>
        private static bool AppendQueryString(StringBuilder fullUrl, bool hasQueryString, string? query)
        {
            fullUrl.Append($"{(hasQueryString ? '&' : '?')}{query}");
            return true;
        }

#pragma warning disable CA1822 // Mark members as static; by-design as it can be overridden.
        /// <summary>
        /// Verify the response status code and handle accordingly.
        /// </summary>
        /// <param name="result">The <see cref="WebApiAgentResult"/> to verify.</param>
        protected WebApiAgentResult VerifyResult(WebApiAgentResult result)
#pragma warning restore CA1822 // Mark members as static
        {
            Check.NotNull(result, nameof(result));

            // Extract any messages sent via the header.
            if (result.Response.Headers.TryGetValues(WebApiConsts.MessagesHeaderName, out IEnumerable<string> msgs) && msgs.Any())
                result.Messages = JsonConvert.DeserializeObject<MessageItemCollection>(msgs.First());

            // Where the status is considered a-OK then get out of here!
            if (result.Response.IsSuccessStatusCode)
                return result;

            // Determine whether the response contains our (beef) headers.
            if (result.Response.Headers.TryGetValues(WebApiConsts.ErrorTypeHeaderName, out IEnumerable<string> errorTypes) && errorTypes.Any())
            {
                // Handle and convert the known errors to their corresponding error types.
                if (Enum.TryParse(errorTypes.First(), out ErrorType errortype))
                {
                    result.ErrorType = errortype;
                    JToken? json = null;

                    if (result.Response.Content.Headers.ContentLength == 0)
                    { }
                    else if (result.Response.Content.Headers.ContentType.MediaType != MediaTypeNames.Application.Json)
                        result.ErrorMessage = result.Content;
                    else
                    {
                        json = JToken.Parse(result.Content!);
                        if (json.Type == JTokenType.String)
                            result.ErrorMessage = json.Value<string>();
                        else if (json.Type == JTokenType.Object)
                            result.ErrorMessage = json["Message"]?.ToObject<string>();
                    }

                    if (result.ErrorType == ErrorType.ValidationError)
                    {
                        if (json != null && json.Type == JTokenType.Object)
                        {
                            foreach (var prop in (json["ModelState"] ?? json).ToObject<Dictionary<string, ICollection<string>>>() ?? new Dictionary<string, ICollection<string>>())
                            {
                                foreach (var text in prop.Value)
                                {
                                    if (result.Messages == null)
                                        result.Messages = new MessageItemCollection();

                                    result.Messages.Add(prop.Key, MessageType.Error, text);
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Create the <see cref="StringContent"/> by JSON serializing the request <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The <see cref="StringContent"/>.</returns>
        protected static StringContent? CreateJsonContentFromValue(object? value)
        {
            if (value == null)
                return null;

            var content = new StringContent(JsonConvert.SerializeObject(value));
            content.Headers.ContentType = MediaTypeHeaderValue.Parse(MediaTypeNames.Application.Json);
            return content;
        }

        /// <summary>
        /// Gets the named header value as a nullable long.
        /// </summary>
        protected static long? GetHeaderValueLong(WebApiAgentResult result, string name)
        {
            if (!result.Response.Headers.TryGetValues(name, out IEnumerable<string> values) || !values.Any())
                return null;

            if (!long.TryParse(values.First(), out long val))
                return null;

            return val;
        }
    }
}