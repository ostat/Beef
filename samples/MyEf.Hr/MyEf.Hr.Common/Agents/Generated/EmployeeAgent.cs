/*
 * This file is automatically generated; any changes will be lost.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoreEx.Configuration;
using CoreEx.Entities;
using CoreEx.Http;
using CoreEx.Json;
using Microsoft.Extensions.Logging;
using MyEf.Hr.Common.Entities;
using RefDataNamespace = MyEf.Hr.Common.Entities;

namespace MyEf.Hr.Common.Agents
{
    /// <summary>
    /// Provides the <see cref="Employee"/> HTTP agent.
    /// </summary>
    public partial class EmployeeAgent : TypedHttpClientBase<EmployeeAgent>, IEmployeeAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeAgent"/> class.
        /// </summary>
        /// <param name="client">The underlying <see cref="HttpClient"/>.</param>
        /// <param name="jsonSerializer">The <see cref="IJsonSerializer"/>.</param>
        /// <param name="executionContext">The <see cref="CoreEx.ExecutionContext"/>.</param>
        /// <param name="settings">The <see cref="SettingsBase"/>.</param>
        /// <param name="logger">The <see cref="ILogger"/>.</param>
        public EmployeeAgent(HttpClient client, IJsonSerializer jsonSerializer, CoreEx.ExecutionContext executionContext, SettingsBase settings, ILogger<EmployeeAgent> logger) 
            : base(client, jsonSerializer, executionContext, settings, logger) { }

        /// <inheritdoc/>
        public Task<HttpResult<Employee?>> GetAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => GetAsync<Employee?>("employees/{id}", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<Employee>> CreateAsync(Employee value, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PostAsync<Employee, Employee>("employees", value, requestOptions: requestOptions, cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<Employee>> UpdateAsync(Employee value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PutAsync<Employee, Employee>("employees/{id}", value, requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<Employee>> PatchAsync(HttpPatchOption patchOption, string value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PatchAsync<Employee>("employees/{id}", patchOption, value, requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult> DeleteAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => DeleteAsync("employees/{id}", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<EmployeeBaseCollectionResult>> GetByArgsAsync(EmployeeArgs? args, PagingArgs? paging = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => GetAsync<EmployeeBaseCollectionResult>("employees", requestOptions: requestOptions.IncludePaging(paging), args: HttpArgs.Create(new HttpArg<EmployeeArgs?>("args", args, HttpArgType.FromUriUseProperties)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<Employee>> TerminateAsync(TerminationDetail value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PostAsync<TerminationDetail, Employee>("employees/{id}/terminate", value, requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);
    }
}