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
using CoreEx.RefData;
using Microsoft.Extensions.Logging;
using My.Hr.Common.Entities;
using RefDataNamespace = My.Hr.Common.Entities;

namespace My.Hr.Common.Agents
{
    /// <summary>
    /// Defines the <b>ReferenceData</b> HTTP agent.
    /// </summary>
    public partial interface IReferenceDataAgent
    {
        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.Gender"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        Task<HttpResult<RefDataNamespace.GenderCollection>> GenderGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.TerminationReason"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        Task<HttpResult<RefDataNamespace.TerminationReasonCollection>> TerminationReasonGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.RelationshipType"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        Task<HttpResult<RefDataNamespace.RelationshipTypeCollection>> RelationshipTypeGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.USState"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        Task<HttpResult<RefDataNamespace.USStateCollection>> USStateGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.PerformanceOutcome"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        Task<HttpResult<RefDataNamespace.PerformanceOutcomeCollection>> PerformanceOutcomeGetAllAsync(ReferenceDataFilter? args = null, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the reference data entries for the specified entities and codes from the query string; e.g: ref?entity=codeX,codeY&amp;entity2=codeZ&amp;entity3
        /// </summary>
        /// <param name="names">The optional list of reference data names.</param>
        /// <param name="requestOptions">The optional <see cref="HttpRequestOptions"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="HttpResult"/>.</returns>
        /// <remarks>The reference data objects will need to be manually extracted from the corresponding response content.</remarks>
        Task<HttpResult> GetNamedAsync(string[] names, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default);
    }
}