/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace MyEf.Hr.Business.Entities
{
    /// <summary>
    /// Represents the Termination Reason entity.
    /// </summary>
    public partial class TerminationReason : ReferenceDataBaseEx<Guid, TerminationReason>
    {
        /// <summary>
        /// An implicit cast from an <see cref="IIdentifier.Id"> to <see cref="TerminationReason"/>.
        /// </summary>
        /// <param name="id">The <see cref="IIdentifier.Id">.</param>
        /// <returns>The corresponding <see cref="TerminationReason"/>.</returns>
        public static implicit operator TerminationReason?(Guid id) => ConvertFromId(id);

        /// <summary>
        /// An implicit cast from a <see cref="IReferenceData.Code"> to <see cref="TerminationReason"/>.
        /// </summary>
        /// <param name="code">The <see cref="IReferenceData.Code">.</param>
        /// <returns>The corresponding <see cref="TerminationReason"/>.</returns>
        public static implicit operator TerminationReason?(string? code) => ConvertFromCode(code);
    }

    /// <summary>
    /// Represents the <see cref="TerminationReason"/> collection.
    /// </summary>
    public partial class TerminationReasonCollection : ReferenceDataCollectionBase<Guid, TerminationReason, TerminationReasonCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminationReasonCollection"/> class.
        /// </summary>
        public TerminationReasonCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminationReasonCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public TerminationReasonCollection(IEnumerable<TerminationReason> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore