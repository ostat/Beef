/*
 * This file is automatically generated; any changes will be lost.
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Beef.Entities;
using Beef.WebApi;
using Newtonsoft.Json.Linq;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Agents
{
    /// <summary>
    /// Defines the <see cref="TripPerson"/> Web API agent.
    /// </summary>
    public partial interface ITripPersonAgent
    {
        /// <summary>
        /// Gets the specified <see cref="TripPerson"/>.
        /// </summary>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<TripPerson?>> GetAsync(string? id, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Creates a new <see cref="TripPerson"/>.
        /// </summary>
        /// <param name="value">The <see cref="TripPerson"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<TripPerson>> CreateAsync(TripPerson value, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Updates an existing <see cref="TripPerson"/>.
        /// </summary>
        /// <param name="value">The <see cref="TripPerson"/>.</param>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<TripPerson>> UpdateAsync(TripPerson value, string? id, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Deletes the specified <see cref="TripPerson"/>.
        /// </summary>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult> DeleteAsync(string? id, WebApiRequestOptions? requestOptions = null);
    }

    /// <summary>
    /// Provides the <see cref="TripPerson"/> Web API agent.
    /// </summary>
    public partial class TripPersonAgent : WebApiAgentBase, ITripPersonAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TripPersonAgent"/> class.
        /// </summary>
        /// <param name="args">The <see cref="IDemoWebApiAgentArgs"/>.</param>
        public TripPersonAgent(IDemoWebApiAgentArgs args) : base(args) { }

        /// <summary>
        /// Gets the specified <see cref="TripPerson"/>.
        /// </summary>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<TripPerson?>> GetAsync(string? id, WebApiRequestOptions? requestOptions = null) =>
            GetAsync<TripPerson?>("api/v1/tripPeople/{id}", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<string?>("id", id) });

        /// <summary>
        /// Creates a new <see cref="TripPerson"/>.
        /// </summary>
        /// <param name="value">The <see cref="TripPerson"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<TripPerson>> CreateAsync(TripPerson value, WebApiRequestOptions? requestOptions = null) =>
            PostAsync<TripPerson>("api/v1/tripPeople", Beef.Check.NotNull(value, nameof(value)), requestOptions: requestOptions,
                args: Array.Empty<WebApiArg>());

        /// <summary>
        /// Updates an existing <see cref="TripPerson"/>.
        /// </summary>
        /// <param name="value">The <see cref="TripPerson"/>.</param>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<TripPerson>> UpdateAsync(TripPerson value, string? id, WebApiRequestOptions? requestOptions = null) =>
            PutAsync<TripPerson>("api/v1/tripPeople/{id}", Beef.Check.NotNull(value, nameof(value)), requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<string?>("id", id) });

        /// <summary>
        /// Deletes the specified <see cref="TripPerson"/>.
        /// </summary>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> DeleteAsync(string? id, WebApiRequestOptions? requestOptions = null) =>
            DeleteAsync("api/v1/tripPeople/{id}", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<string?>("id", id) });
    }
}

#pragma warning restore
#nullable restore