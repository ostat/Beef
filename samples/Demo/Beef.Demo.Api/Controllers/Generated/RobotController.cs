/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Api.Controllers
{
    /// <summary>
    /// Provides the <see cref="Robot"/> Web API functionality.
    /// </summary>
    [Route("api/v1/robots")]
    [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
    public partial class RobotController : ControllerBase
    {
        private readonly WebApi _webApi;
        private readonly IRobotManager _manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="RobotController"/> class.
        /// </summary>
        /// <param name="webApi">The <see cref="WebApi"/>.</param>
        /// <param name="manager">The <see cref="IRobotManager"/>.</param>
        public RobotController(WebApi webApi, IRobotManager manager)
            { _webApi = webApi ?? throw new ArgumentNullException(nameof(webApi)); _manager = manager ?? throw new ArgumentNullException(nameof(manager)); RobotControllerCtor(); }

        partial void RobotControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="Robot"/>.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <returns>The selected <see cref="Robot"/> where found.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Robot), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> Get(Guid id) =>
            _webApi.GetAsync<Robot?>(Request, p => _manager.GetAsync(id));

        /// <summary>
        /// Creates a new <see cref="Robot"/>.
        /// </summary>
        /// <returns>The created <see cref="Robot"/>.</returns>
        [HttpPost("")]
        [AcceptsBody(typeof(Robot))]
        [ProducesResponseType(typeof(Robot), (int)HttpStatusCode.Created)]
        public Task<IActionResult> Create() =>
            _webApi.PostAsync<Robot, Robot>(Request, p => _manager.CreateAsync(p.Value!), locationUri: r => new Uri($"/api/v1/robots/{r.Id}", UriKind.Relative));

        /// <summary>
        /// Updates an existing <see cref="Robot"/>.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <returns>The updated <see cref="Robot"/>.</returns>
        [HttpPut("{id}")]
        [AcceptsBody(typeof(Robot))]
        [ProducesResponseType(typeof(Robot), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Update(Guid id) =>
            _webApi.PutAsync<Robot, Robot>(Request, p => _manager.UpdateAsync(p.Value!, id));

        /// <summary>
        /// Patches an existing <see cref="Robot"/>.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <returns>The patched <see cref="Robot"/>.</returns>
        [HttpPatch("{id}")]
        [AcceptsBody(typeof(Robot))]
        [ProducesResponseType(typeof(Robot), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Patch(Guid id) =>
            _webApi.PatchAsync<Robot>(Request, get: _ => _manager.GetAsync(id), put: p => _manager.UpdateAsync(p.Value!, id));

        /// <summary>
        /// Deletes the specified <see cref="Robot"/>.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> Delete(Guid id) =>
            _webApi.DeleteAsync(Request, p => _manager.DeleteAsync(id));

        /// <summary>
        /// Gets the <see cref="RobotCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="modelNo">The Model number.</param>
        /// <param name="serialNo">The Unique serial number.</param>
        /// <param name="powerSources">The Power Sources (see <see cref="RefDataNamespace.PowerSource"/>).</param>
        /// <returns>The <see cref="RobotCollection"/></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(RobotCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> GetByArgs([FromQuery(Name="model-no")] string? modelNo = default, [FromQuery(Name="serial-no")] string? serialNo = default, [FromQuery(Name="power-sources")] List<string>? powerSources = default)
        {
            var args = new RobotArgs { ModelNo = modelNo, SerialNo = serialNo, PowerSourcesSids = powerSources };
            return _webApi.GetAsync<RobotCollectionResult>(Request, p => _manager.GetByArgsAsync(args, p.RequestOptions.Paging), alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Raises a <see cref="Robot.PowerSource"/> change event.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="powerSource">The Power Source.</param>
        [HttpPost("{id}/powerSource/{powerSource}")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public Task<IActionResult> RaisePowerSourceChange(Guid id, string? powerSource) =>
            _webApi.PostAsync(Request, p => _manager.RaisePowerSourceChangeAsync(id, powerSource), statusCode: HttpStatusCode.Accepted, operationType: CoreEx.OperationType.Unspecified);
    }
}

#pragma warning restore
#nullable restore