/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Api.Controllers
{
    /// <summary>
    /// Provides the <see cref="Contact"/> Web API functionality.
    /// </summary>
    [AllowAnonymous]
    [Route("api/v1/contacts")]
    [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
    public partial class ContactController : ControllerBase
    {
        private readonly WebApi _webApi;
        private readonly IContactManager _manager;
        private readonly Microsoft.Extensions.Configuration.IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactController"/> class.
        /// </summary>
        /// <param name="webApi">The <see cref="WebApi"/>.</param>
        /// <param name="manager">The <see cref="IContactManager"/>.</param>
        /// <param name="config">The <see cref="Microsoft.Extensions.Configuration.IConfiguration"/>.</param>
        public ContactController(WebApi webApi, IContactManager manager, Microsoft.Extensions.Configuration.IConfiguration config)
        {
            _webApi = webApi ?? throw new ArgumentNullException(nameof(webApi));
            _manager = manager ?? throw new ArgumentNullException(nameof(manager));
            _config = config ?? throw new ArgumentNullException(nameof(config));
            ContactControllerCtor();
        }

        partial void ContactControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the <see cref="ContactCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <returns>The <see cref="ContactCollection"/></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(Common.Entities.ContactCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> GetAll() =>
            _webApi.GetAsync<ContactCollectionResult>(Request, p => _manager.GetAllAsync(), alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary>
        /// Gets the specified <see cref="Contact"/>.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <returns>The selected <see cref="Contact"/> where found.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Common.Entities.Contact), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> Get(Guid id) =>
            _webApi.GetAsync<Contact?>(Request, p => _manager.GetAsync(id));

        /// <summary>
        /// Creates a new <see cref="Contact"/>.
        /// </summary>
        /// <returns>The created <see cref="Contact"/>.</returns>
        [HttpPost("")]
        [AcceptsBody(typeof(Common.Entities.Contact))]
        [ProducesResponseType(typeof(Common.Entities.Contact), (int)HttpStatusCode.Created)]
        public Task<IActionResult> Create() =>
            _webApi.PostAsync<Contact, Contact>(Request, p => _manager.CreateAsync(p.Value!), statusCode: HttpStatusCode.Created);

        /// <summary>
        /// Updates an existing <see cref="Contact"/>.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <returns>The updated <see cref="Contact"/>.</returns>
        [HttpPut("{id}")]
        [AcceptsBody(typeof(Common.Entities.Contact))]
        [ProducesResponseType(typeof(Common.Entities.Contact), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Update(Guid id) =>
            _webApi.PutAsync<Contact, Contact>(Request, p => _manager.UpdateAsync(p.Value!, id));

        /// <summary>
        /// Deletes the specified <see cref="Contact"/>.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> Delete(Guid id) =>
            _webApi.DeleteAsync(Request, p => _manager.DeleteAsync(id));

        /// <summary>
        /// Raise Event.
        /// </summary>
        /// <param name="throwError">Indicates whether throw a DivideByZero exception.</param>
        [HttpPost("raise")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> RaiseEvent(bool throwError) =>
            _webApi.PostAsync(Request, p => _manager.RaiseEventAsync(throwError), statusCode: HttpStatusCode.NoContent, operationType: CoreEx.OperationType.Unspecified);
    }
}

#pragma warning restore
#nullable restore