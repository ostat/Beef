/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.DataSvc
{
    /// <summary>
    /// Provides the <see cref="Contact"/> data repository services.
    /// </summary>
    public partial class ContactDataSvc : IContactDataSvc
    {
        private readonly IContactData _data;
        private readonly IRequestCache _cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDataSvc"/> class.
        /// </summary>
        /// <param name="data">The <see cref="IContactData"/>.</param>
        /// <param name="cache">The <see cref="IRequestCache"/>.</param>
        public ContactDataSvc(IContactData data, IRequestCache cache)
            { _data = data ?? throw new ArgumentNullException(nameof(data)); _cache = cache ?? throw new ArgumentNullException(nameof(cache)); ContactDataSvcCtor(); }

        partial void ContactDataSvcCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the <see cref="ContactCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <returns>The <see cref="ContactCollectionResult"/>.</returns>
        public Task<ContactCollectionResult> GetAllAsync() => DataSvcInvoker.Current.InvokeAsync(this, _ => _data.GetAllAsync());

        /// <summary>
        /// Gets the specified <see cref="Contact"/>.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <returns>The selected <see cref="Contact"/> where found.</returns>
        public Task<Contact?> GetAsync(Guid id) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            if (_cache.TryGetValue(id, out Contact? __val))
                return __val;

            var __result = await _data.GetAsync(id).ConfigureAwait(false);
            return _cache.SetValue(__result);
        });

        /// <summary>
        /// Creates a new <see cref="Contact"/>.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/>.</param>
        /// <returns>The created <see cref="Contact"/>.</returns>
        public Task<Contact> CreateAsync(Contact value) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            var __result = await _data.CreateAsync(value ?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            return _cache.SetValue(__result);
        });

        /// <summary>
        /// Updates an existing <see cref="Contact"/>.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/>.</param>
        /// <returns>The updated <see cref="Contact"/>.</returns>
        public Task<Contact> UpdateAsync(Contact value) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            var __result = await _data.UpdateAsync(value ?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            return _cache.SetValue(__result);
        });

        /// <summary>
        /// Deletes the specified <see cref="Contact"/>.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        public Task DeleteAsync(Guid id) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            await _data.DeleteAsync(id).ConfigureAwait(false);
            _cache.Remove<Contact>(id);
        });

        /// <summary>
        /// Raise Event.
        /// </summary>
        /// <param name="throwError">Indicates whether throw a DivideByZero exception.</param>
        public Task RaiseEventAsync(bool throwError) => DataSvcInvoker.Current.InvokeAsync(this, async _ =>
        {
            await _data.RaiseEventAsync(throwError).ConfigureAwait(false);
        });
    }
}

#pragma warning restore
#nullable restore