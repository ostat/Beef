/*
 * This file is automatically generated; any changes will be lost. 
 */

namespace My.Hr.Business.Entities;

/// <summary>
/// Represents the Employee entity.
/// </summary>
public partial class Employee : EmployeeBase, IETag, IChangeLogEx
{
    private Address? _address;
    private EmergencyContactCollection? _emergencyContacts;
    private string? _etag;
    private ChangeLogEx? _changeLog;

    /// <summary>
    /// Gets or sets the Address (see <see cref="Business.Entities.Address"/>).
    /// </summary>
    public Address? Address { get => _address; set => SetValue(ref _address, value); }

    /// <summary>
    /// Gets or sets the Emergency Contacts.
    /// </summary>
    public EmergencyContactCollection? EmergencyContacts { get => _emergencyContacts; set => SetValue(ref _emergencyContacts, value); }

    /// <summary>
    /// Gets or sets the ETag.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? ETag { get => _etag; set => SetValue(ref _etag, value); }

    /// <summary>
    /// Gets or sets the Change Log (see <see cref="CoreEx.Entities.ChangeLog"/>).
    /// </summary>
    public ChangeLogEx? ChangeLog { get => _changeLog; set => SetValue(ref _changeLog, value); }

    /// <inheritdoc/>
    protected override IEnumerable<IPropertyValue> GetPropertyValues()
    {
        foreach (var pv in base.GetPropertyValues())
            yield return pv;

        yield return CreateProperty(nameof(Address), Address, v => Address = v);
        yield return CreateProperty(nameof(EmergencyContacts), EmergencyContacts, v => EmergencyContacts = v);
        yield return CreateProperty(nameof(ETag), ETag, v => ETag = v);
        yield return CreateProperty(nameof(ChangeLog), ChangeLog, v => ChangeLog = v);
    }
}