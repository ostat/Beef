/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Data
{
    /// <summary>
    /// Provides the <see cref="Contact"/> data access.
    /// </summary>
    public partial class ContactData : IContactData
    {
        private readonly IEfDb _ef;
        private readonly IEventPublisher _events;
        private Func<IQueryable<EfModel.Contact>, IQueryable<EfModel.Contact>>? _getAllOnQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactData"/> class.
        /// </summary>
        /// <param name="ef">The <see cref="IEfDb"/>.</param>
        /// <param name="events">The <see cref="IEventPublisher"/>.</param>
        public ContactData(IEfDb ef, IEventPublisher events)
            { _ef = ef ?? throw new ArgumentNullException(nameof(ef)); _events = events ?? throw new ArgumentNullException(nameof(events)); ContactDataCtor(); }

        partial void ContactDataCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the <see cref="ContactCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <returns>The <see cref="ContactCollectionResult"/>.</returns>
        public Task<ContactCollectionResult> GetAllAsync() => DataInvoker.Current.InvokeAsync(this, _ =>
        {
            return _ef.Query<Contact, EfModel.Contact>(q => _getAllOnQuery?.Invoke(q) ?? q).SelectResultAsync<ContactCollectionResult, ContactCollection>();
        });

        /// <summary>
        /// Gets the specified <see cref="Contact"/>.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <returns>The selected <see cref="Contact"/> where found.</returns>
        public Task<Contact?> GetAsync(Guid id) => DataInvoker.Current.InvokeAsync(this, _ =>
        {
            return _ef.GetAsync<Contact, EfModel.Contact>(id);
        });

        /// <summary>
        /// Creates a new <see cref="Contact"/>.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/>.</param>
        /// <returns>The created <see cref="Contact"/>.</returns>
        public Task<Contact> CreateAsync(Contact value) => DataInvoker.Current.InvokeAsync(this, async _ =>
        {
            var __result = await _ef.CreateAsync<Contact, EfModel.Contact>(value?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            _events.PublishValueEvent(__result, new Uri($"/contact/{__result.Id}", UriKind.Relative), $"Demo.Contact", "Create");
            return __result;
        }, new BusinessInvokerArgs { EventPublisher = _events });

        /// <summary>
        /// Updates an existing <see cref="Contact"/>.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/>.</param>
        /// <returns>The updated <see cref="Contact"/>.</returns>
        public Task<Contact> UpdateAsync(Contact value) => DataInvoker.Current.InvokeAsync(this, async _ =>
        {
            var __result = await _ef.UpdateAsync<Contact, EfModel.Contact>(value?? throw new ArgumentNullException(nameof(value))).ConfigureAwait(false);
            _events.PublishValueEvent(__result, new Uri($"/contact/{__result.Id}", UriKind.Relative), $"Demo.Contact", "Update");
            return __result;
        }, new BusinessInvokerArgs { EventPublisher = _events });

        /// <summary>
        /// Deletes the specified <see cref="Contact"/>.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        public Task DeleteAsync(Guid id) => DataInvoker.Current.InvokeAsync(this, async _ =>
        {
            await _ef.DeleteAsync<Contact, EfModel.Contact>(id).ConfigureAwait(false);
            _events.PublishValueEvent(new Contact { Id = id }, new Uri($"/contact/{id}", UriKind.Relative), $"Demo.Contact", "Delete");
        }, new BusinessInvokerArgs { EventPublisher = _events });

        /// <summary>
        /// Raise Event.
        /// </summary>
        /// <param name="throwError">Indicates whether throw a DivideByZero exception.</param>
        public Task RaiseEventAsync(bool throwError) => DataInvoker.Current.InvokeAsync(this, _ => RaiseEventOnImplementationAsync(throwError));

        /// <summary>
        /// Provides the <see cref="Contact"/> and Entity Framework <see cref="EfModel.Contact"/> <i>AutoMapper</i> mapping.
        /// </summary>
        public partial class EfMapperProfile : AutoMapper.Profile
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="EfMapperProfile"/> class.
            /// </summary>
            public EfMapperProfile()
            {
                var s2d = CreateMap<Contact, EfModel.Contact>();
                s2d.ForMember(d => d.ContactId, o => o.MapFrom(s => s.Id));
                s2d.ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName));
                s2d.ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName));
                s2d.ForMember(d => d.StatusCode, o => o.MapFrom(s => s.StatusSid));

                var d2s = CreateMap<EfModel.Contact, Contact>();
                d2s.ForMember(s => s.Id, o => o.MapFrom(d => d.ContactId));
                d2s.ForMember(s => s.FirstName, o => o.MapFrom(d => d.FirstName));
                d2s.ForMember(s => s.LastName, o => o.MapFrom(d => d.LastName));
                d2s.ForMember(s => s.StatusSid, o => o.MapFrom(d => d.StatusCode));
                d2s.ForMember(s => s.InternalCode, o => o.Ignore());

                EfMapperProfileCtor(s2d, d2s);
            }

            partial void EfMapperProfileCtor(AutoMapper.IMappingExpression<Contact, EfModel.Contact> s2d, AutoMapper.IMappingExpression<EfModel.Contact, Contact> d2s); // Enables the constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore