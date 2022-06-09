/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using CoreEx.Entities;
using CoreEx.Entities.Extended;
using CoreEx.RefData;
using Newtonsoft.Json;
using RefDataNamespace = My.Hr.Business.Entities;

namespace My.Hr.Business.Entities
{
    /// <summary>
    /// Represents the Emergency Contact entity.
    /// </summary>
    public partial class EmergencyContact : EntityBase<EmergencyContact>, IIdentifier<Guid>
    {
        private Guid _id;
        private string? _firstName;
        private string? _lastName;
        private string? _phoneNo;
        private string? _relationshipSid;
        private string? _relationshipText;

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Guid Id { get => _id; set => SetValue(ref _id, value); }

        /// <summary>
        /// Gets or sets the First Name.
        /// </summary>
        public string? FirstName { get => _firstName; set => SetValue(ref _firstName, value); }

        /// <summary>
        /// Gets or sets the Last Name.
        /// </summary>
        public string? LastName { get => _lastName; set => SetValue(ref _lastName, value); }

        /// <summary>
        /// Gets or sets the Phone No.
        /// </summary>
        public string? PhoneNo { get => _phoneNo; set => SetValue(ref _phoneNo, value); }

        /// <summary>
        /// Gets or sets the <see cref="Relationship"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        public string? RelationshipSid { get => _relationshipSid; set => SetValue(ref _relationshipSid, value); }

        /// <summary>
        /// Gets the corresponding <see cref="Relationship"/> text (read-only where selected).
        /// </summary>
        public string? RelationshipText => RefDataNamespace.RelationshipType.GetRefDataText(_relationshipSid);

        /// <summary>
        /// Gets or sets the Relationship (see <see cref="RefDataNamespace.RelationshipType"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public RefDataNamespace.RelationshipType? Relationship { get => _relationshipSid; set => SetValue(ref _relationshipSid, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(Id, v => Id = v);
            yield return CreateProperty(FirstName, v => FirstName = v);
            yield return CreateProperty(LastName, v => LastName = v);
            yield return CreateProperty(PhoneNo, v => PhoneNo = v);
            yield return CreateProperty(RelationshipSid, v => RelationshipSid = v);
        }
    }

    /// <summary>
    /// Represents the <see cref="EmergencyContact"/> collection.
    /// </summary>
    public partial class EmergencyContactCollection : EntityBaseCollection<EmergencyContact, EmergencyContactCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmergencyContactCollection"/> class.
        /// </summary>
        public EmergencyContactCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmergencyContactCollection"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        public EmergencyContactCollection(IEnumerable<EmergencyContact> collection) => AddRange(collection);
    }
}

#pragma warning restore
#nullable restore