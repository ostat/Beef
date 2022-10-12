/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Api.Controllers
{
    /// <summary>
    /// Provides the <b>Config</b> Web API functionality.
    /// </summary>
    [Route("api/v1/envvars")]
    [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
    public partial class ConfigController : ControllerBase
    {
        private readonly WebApi _webApi;
        private readonly IConfigManager _manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigController"/> class.
        /// </summary>
        /// <param name="webApi">The <see cref="WebApi"/>.</param>
        /// <param name="manager">The <see cref="IConfigManager"/>.</param>
        public ConfigController(WebApi webApi, IConfigManager manager)
            { _webApi = webApi ?? throw new ArgumentNullException(nameof(webApi)); _manager = manager ?? throw new ArgumentNullException(nameof(manager)); ConfigControllerCtor(); }

        partial void ConfigControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Get Env Vars.
        /// </summary>
        /// <returns>A resultant <see cref="System.Collections.IDictionary"/>.</returns>
        [HttpPost("")]
        [ProducesResponseType(typeof(System.Collections.IDictionary), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> GetEnvVars() =>
            _webApi.PostAsync<System.Collections.IDictionary>(Request, p => _manager.GetEnvVarsAsync(), statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent, operationType: CoreEx.OperationType.Unspecified);
    }
}

#pragma warning restore
#nullable restore