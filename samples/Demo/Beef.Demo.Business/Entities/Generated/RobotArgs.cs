/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities;

/// <summary>
/// Represents the <see cref="Robot"/> arguments entity.
/// </summary>
public partial class RobotArgs : EntityBase
{
    private string? _modelNo;
    private string? _serialNo;
    private List<string?>? _powerSourcesSids;

    /// <summary>
    /// Gets or sets the Model number.
    /// </summary>
    [JsonPropertyName("model-no")]
    public string? ModelNo { get => _modelNo; set => SetValue(ref _modelNo, value); }

    /// <summary>
    /// Gets or sets the Unique serial number.
    /// </summary>
    [JsonPropertyName("serial-no")]
    public string? SerialNo { get => _serialNo; set => SetValue(ref _serialNo, value); }

    /// <summary>
    /// Gets or sets the <see cref="PowerSources"/> list using the underlying Serialization Identifier (SID).
    /// </summary>
    [JsonPropertyName("power-sources")]
    public List<string?>? PowerSourcesSids { get => _powerSourcesSids; set => SetValue(ref _powerSourcesSids, value, propertyName: nameof(PowerSources)); }

    /// <summary>
    /// Gets or sets the Power Sources (see <see cref="RefDataNamespace.PowerSource"/>).
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [JsonIgnore]
    public ReferenceDataCodeList<RefDataNamespace.PowerSource>? PowerSources { get => new ReferenceDataCodeList<RefDataNamespace.PowerSource>(ref _powerSourcesSids); set => SetValue(ref _powerSourcesSids, value?.ToCodeList(), propertyName: nameof(PowerSources)); }

    /// <inheritdoc/>
    protected override IEnumerable<IPropertyValue> GetPropertyValues()
    {
        yield return CreateProperty(nameof(ModelNo), ModelNo, v => ModelNo = v);
        yield return CreateProperty(nameof(SerialNo), SerialNo, v => SerialNo = v);
        yield return CreateProperty(nameof(PowerSourcesSids), PowerSourcesSids, v => PowerSourcesSids = v);
    }
}

#pragma warning restore
#nullable restore