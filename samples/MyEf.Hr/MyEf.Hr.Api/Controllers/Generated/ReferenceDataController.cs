/*
 * This file is automatically generated; any changes will be lost. 
 */

using CommonRefDataNamespace = MyEf.Hr.Common.Entities;

namespace MyEf.Hr.Api.Controllers;

/// <summary>
/// Provides the <b>ReferenceData</b> Web API functionality.
/// </summary>
public partial class ReferenceDataController : ControllerBase
{
    private readonly ReferenceDataContentWebApi _webApi;
    private readonly ReferenceDataOrchestrator _orchestrator;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReferenceDataController"/> class.
    /// </summary>
    /// <param name="webApi">The <see cref="ReferenceDataContentWebApi"/>.</param>
    /// <param name="orchestrator">The <see cref="ReferenceDataOrchestrator"/>.</param>
    public ReferenceDataController(ReferenceDataContentWebApi webApi, ReferenceDataOrchestrator orchestrator)
        { _webApi = webApi.ThrowIfNull(); _orchestrator = orchestrator.ThrowIfNull(); }

    /// <summary> 
    /// Gets all of the <see cref="RefDataNamespace.Gender"/> reference data items that match the specified criteria.
    /// </summary>
    /// <param name="codes">The reference data code list.</param>
    /// <param name="text">The reference data text (including wildcards).</param>
    /// <returns>A RefDataNamespace.Gender collection.</returns>
    [HttpGet()]
    [Route("ref/genders")]
    [ProducesResponseType(typeof(IEnumerable<CommonRefDataNamespace.Gender>), (int)HttpStatusCode.OK)]
    public Task<IActionResult> GenderGetAll([FromQuery] IEnumerable<string>? codes = default, string? text = default)
        => _webApi.GetAsync(Request, p => _orchestrator.GetWithFilterAsync<RefDataNamespace.Gender>(codes, text, p.RequestOptions.IncludeInactive));

    /// <summary> 
    /// Gets all of the <see cref="RefDataNamespace.TerminationReason"/> reference data items that match the specified criteria.
    /// </summary>
    /// <param name="codes">The reference data code list.</param>
    /// <param name="text">The reference data text (including wildcards).</param>
    /// <returns>A RefDataNamespace.TerminationReason collection.</returns>
    [HttpGet()]
    [Route("ref/terminationReasons")]
    [ProducesResponseType(typeof(IEnumerable<CommonRefDataNamespace.TerminationReason>), (int)HttpStatusCode.OK)]
    public Task<IActionResult> TerminationReasonGetAll([FromQuery] IEnumerable<string>? codes = default, string? text = default)
        => _webApi.GetAsync(Request, p => _orchestrator.GetWithFilterAsync<RefDataNamespace.TerminationReason>(codes, text, p.RequestOptions.IncludeInactive));

    /// <summary> 
    /// Gets all of the <see cref="RefDataNamespace.RelationshipType"/> reference data items that match the specified criteria.
    /// </summary>
    /// <param name="codes">The reference data code list.</param>
    /// <param name="text">The reference data text (including wildcards).</param>
    /// <returns>A RefDataNamespace.RelationshipType collection.</returns>
    [HttpGet()]
    [Route("ref/relationshipTypes")]
    [ProducesResponseType(typeof(IEnumerable<CommonRefDataNamespace.RelationshipType>), (int)HttpStatusCode.OK)]
    public Task<IActionResult> RelationshipTypeGetAll([FromQuery] IEnumerable<string>? codes = default, string? text = default)
        => _webApi.GetAsync(Request, p => _orchestrator.GetWithFilterAsync<RefDataNamespace.RelationshipType>(codes, text, p.RequestOptions.IncludeInactive));

    /// <summary> 
    /// Gets all of the <see cref="RefDataNamespace.USState"/> reference data items that match the specified criteria.
    /// </summary>
    /// <param name="codes">The reference data code list.</param>
    /// <param name="text">The reference data text (including wildcards).</param>
    /// <returns>A RefDataNamespace.USState collection.</returns>
    [HttpGet()]
    [Route("ref/usStates")]
    [ProducesResponseType(typeof(IEnumerable<CommonRefDataNamespace.USState>), (int)HttpStatusCode.OK)]
    public Task<IActionResult> USStateGetAll([FromQuery] IEnumerable<string>? codes = default, string? text = default)
        => _webApi.GetAsync(Request, p => _orchestrator.GetWithFilterAsync<RefDataNamespace.USState>(codes, text, p.RequestOptions.IncludeInactive));

    /// <summary> 
    /// Gets all of the <see cref="RefDataNamespace.PerformanceOutcome"/> reference data items that match the specified criteria.
    /// </summary>
    /// <param name="codes">The reference data code list.</param>
    /// <param name="text">The reference data text (including wildcards).</param>
    /// <returns>A RefDataNamespace.PerformanceOutcome collection.</returns>
    [HttpGet()]
    [Route("ref/performanceOutcomes")]
    [ProducesResponseType(typeof(IEnumerable<CommonRefDataNamespace.PerformanceOutcome>), (int)HttpStatusCode.OK)]
    public Task<IActionResult> PerformanceOutcomeGetAll([FromQuery] IEnumerable<string>? codes = default, string? text = default)
        => _webApi.GetAsync(Request, p => _orchestrator.GetWithFilterAsync<RefDataNamespace.PerformanceOutcome>(codes, text, p.RequestOptions.IncludeInactive));

    /// <summary>
    /// Gets the reference data entries for the specified entities and codes from the query string; e.g: ref?entity=codeX,codeY&amp;entity2=codeZ&amp;entity3
    /// </summary>
    /// <returns>A <see cref="ReferenceDataMultiCollection"/>.</returns>
    [HttpGet()]
    [Route("ref")]
    [ProducesResponseType(typeof(IEnumerable<CoreEx.RefData.ReferenceDataMultiItem>), (int)HttpStatusCode.OK)]
    [ApiExplorerSettings(IgnoreApi = true)]
    public Task<IActionResult> GetNamed() => _webApi.GetAsync(Request, p => _orchestrator.GetNamedAsync(p.RequestOptions));
}