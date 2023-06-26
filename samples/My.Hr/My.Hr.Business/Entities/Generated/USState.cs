/*
 * This file is automatically generated; any changes will be lost. 
 */

namespace My.Hr.Business.Entities;

/// <summary>
/// Represents the US State entity.
/// </summary>
public partial class USState : ReferenceDataBaseEx<Guid, USState>
{
    /// <summary>
    /// An implicit cast from an <see cref="IIdentifier.Id"> to <see cref="USState"/>.
    /// </summary>
    /// <param name="id">The <see cref="IIdentifier.Id">.</param>
    /// <returns>The corresponding <see cref="USState"/>.</returns>
    public static implicit operator USState?(Guid id) => ConvertFromId(id);

    /// <summary>
    /// An implicit cast from a <see cref="IReferenceData.Code"> to <see cref="USState"/>.
    /// </summary>
    /// <param name="code">The <see cref="IReferenceData.Code">.</param>
    /// <returns>The corresponding <see cref="USState"/>.</returns>
    public static implicit operator USState?(string? code) => ConvertFromCode(code);
}

/// <summary>
/// Represents the <see cref="USState"/> collection.
/// </summary>
public partial class USStateCollection : ReferenceDataCollectionBase<Guid, USState, USStateCollection>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="USStateCollection"/> class.
    /// </summary>
    public USStateCollection() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="USStateCollection"/> class with <paramref name="items"/> to add.
    /// </summary>
    /// <param name="items">The items to add.</param>
    public USStateCollection(IEnumerable<USState> items) => AddRange(items);
}