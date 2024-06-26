/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Api.Controllers;

/// <summary>
/// Provides the <see cref="Gender"/> Web API functionality.
/// </summary>
[AllowAnonymous]
[Consumes(System.Net.Mime.MediaTypeNames.Application.Json)]
[Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
public partial class GenderController : ControllerBase
{
    private readonly ReferenceDataContentWebApi _webApi;
    private readonly IGenderManager _manager;

    /// <summary>
    /// Initializes a new instance of the <see cref="GenderController"/> class.
    /// </summary>
    /// <param name="webApi">The <see cref="WebApi"/>.</param>
    /// <param name="manager">The <see cref="IGenderManager"/>.</param>
    public GenderController(ReferenceDataContentWebApi webApi, IGenderManager manager)
        { _webApi = webApi.ThrowIfNull(); _manager = manager.ThrowIfNull(); GenderControllerCtor(); }

    partial void GenderControllerCtor(); // Enables additional functionality to be added to the constructor.

    /// <summary>
    /// Gets the specified <see cref="Gender"/>.
    /// </summary>
    /// <param name="id">The <see cref="Gender"/> identifier.</param>
    /// <returns>The selected <see cref="Gender"/> where found.</returns>
    [HttpGet("api/v1/demo/ref/genders/{id}", Name="Gender_Get")]
    [ProducesResponseType(typeof(Common.Entities.Gender), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public Task<IActionResult> Get(Guid id)
        => _webApi.GetWithResultAsync<Gender?>(Request, p => _manager.GetAsync(id));

    /// <summary>
    /// Creates a new <see cref="Gender"/>.
    /// </summary>
    /// <returns>The created <see cref="Gender"/>.</returns>
    [HttpPost("api/v1/demo/ref/genders", Name="Gender_Create")]
    [AcceptsBody(typeof(Common.Entities.Gender))]
    [ProducesResponseType(typeof(Common.Entities.Gender), (int)HttpStatusCode.Created)]
    public Task<IActionResult> Create()
        => _webApi.PostWithResultAsync<Gender, Gender>(Request, p => _manager.CreateAsync(p.Value!), statusCode: HttpStatusCode.Created);

    /// <summary>
    /// Updates an existing <see cref="Gender"/>.
    /// </summary>
    /// <param name="id">The <see cref="Gender"/> identifier.</param>
    /// <returns>The updated <see cref="Gender"/>.</returns>
    [HttpPut("api/v1/demo/ref/genders/{id}", Name="Gender_Update")]
    [AcceptsBody(typeof(Common.Entities.Gender))]
    [ProducesResponseType(typeof(Common.Entities.Gender), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public Task<IActionResult> Update(Guid id)
        => _webApi.PutWithResultAsync<Gender, Gender>(Request, p => _manager.UpdateAsync(p.Value!, id));
}

#pragma warning restore
#nullable restore