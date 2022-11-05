/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities
{
    /// <summary>
    /// Represents the Postal Info entity.
    /// </summary>
    public partial class PostalInfo : EntityBase, IETag
    {
        private string? _countrySid;
        private string? _countryText;
        private string? _city;
        private string? _state;
        private PlaceInfoCollection? _places;
        private string? _etag;

        /// <summary>
        /// Gets or sets the <see cref="Country"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonPropertyName("country")]
        public string? CountrySid { get => _countrySid; set => SetValue(ref _countrySid, value); }

        /// <summary>
        /// Gets the corresponding <see cref="Country"/> text (read-only where selected).
        /// </summary>
        public string? CountryText => RefDataNamespace.Country.GetRefDataText(_countrySid); 

        /// <summary>
        /// Gets or sets the Country (see <see cref="RefDataNamespace.Country"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonIgnore]
        public RefDataNamespace.Country? Country { get => _countrySid; set => SetValue(ref _countrySid, value); }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        public string? City { get => _city; set => SetValue(ref _city, value); }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        public string? State { get => _state; set => SetValue(ref _state, value); }

        /// <summary>
        /// Gets or sets the Places.
        /// </summary>
        public PlaceInfoCollection? Places { get => _places; set => SetValue(ref _places, value); }

        /// <summary>
        /// Gets or sets the ETag.
        /// </summary>
        [JsonIgnore]
        public string? ETag { get => _etag; set => SetValue(ref _etag, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(nameof(CountrySid), CountrySid, v => CountrySid = v);
            yield return CreateProperty(nameof(City), City, v => City = v);
            yield return CreateProperty(nameof(State), State, v => State = v);
            yield return CreateProperty(nameof(Places), Places, v => Places = v);
            yield return CreateProperty(nameof(ETag), ETag, v => ETag = v);
        }
    }
}

#pragma warning restore
#nullable restore