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
    /// Represents the <see cref="Employee"/> base entity.
    /// </summary>
    public partial class EmployeeBase : EntityBase<EmployeeBase>, IIdentifier<Guid>
    {
        private Guid _id;
        private string? _email;
        private string? _firstName;
        private string? _lastName;
        private string? _genderSid;
        private string? _genderText;
        private DateTime _birthday;
        private DateTime _startDate;
        private TerminationDetail? _termination;
        private string? _phoneNo;

        /// <summary>
        /// Gets or sets the <see cref="Employee"/> identifier.
        /// </summary>
        public Guid Id { get => _id; set => SetValue(ref _id, value); }

        /// <summary>
        /// Gets or sets the Unique <see cref="Employee"/> Email.
        /// </summary>
        public string? Email { get => _email; set => SetValue(ref _email, value); }

        /// <summary>
        /// Gets or sets the First Name.
        /// </summary>
        public string? FirstName { get => _firstName; set => SetValue(ref _firstName, value); }

        /// <summary>
        /// Gets or sets the Last Name.
        /// </summary>
        public string? LastName { get => _lastName; set => SetValue(ref _lastName, value); }

        /// <summary>
        /// Gets or sets the <see cref="Gender"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        public string? GenderSid { get => _genderSid; set => SetValue(ref _genderSid, value); }

        /// <summary>
        /// Gets the corresponding <see cref="Gender"/> text (read-only where selected).
        /// </summary>
        public string? GenderText => RefDataNamespace.Gender.GetRefDataText(_genderSid);

        /// <summary>
        /// Gets or sets the Gender (see <see cref="RefDataNamespace.Gender"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public RefDataNamespace.Gender? Gender { get => _genderSid; set => SetValue(ref _genderSid, value); }

        /// <summary>
        /// Gets or sets the Birthday.
        /// </summary>
        public DateTime Birthday { get => _birthday; set => SetValue(ref _birthday, value, transform: DateTimeTransform.DateOnly); }

        /// <summary>
        /// Gets or sets the Start Date.
        /// </summary>
        public DateTime StartDate { get => _startDate; set => SetValue(ref _startDate, value, transform: DateTimeTransform.DateOnly); }

        /// <summary>
        /// Gets or sets the Termination (see <see cref="Business.Entities.TerminationDetail"/>).
        /// </summary>
        public TerminationDetail? Termination { get => _termination; set => SetValue(ref _termination, value); }

        /// <summary>
        /// Gets or sets the Phone No.
        /// </summary>
        public string? PhoneNo { get => _phoneNo; set => SetValue(ref _phoneNo, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(Id, v => Id = v);
            yield return CreateProperty(Email, v => Email = v);
            yield return CreateProperty(FirstName, v => FirstName = v);
            yield return CreateProperty(LastName, v => LastName = v);
            yield return CreateProperty(GenderSid, v => GenderSid = v);
            yield return CreateProperty(Birthday, v => Birthday = v);
            yield return CreateProperty(StartDate, v => StartDate = v);
            yield return CreateProperty(Termination, v => Termination = v);
            yield return CreateProperty(PhoneNo, v => PhoneNo = v);
        }
    }

    /// <summary>
    /// Represents the <see cref="EmployeeBase"/> collection.
    /// </summary>
    public partial class EmployeeBaseCollection : EntityBaseCollection<EmployeeBase, EmployeeBaseCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBaseCollection"/> class.
        /// </summary>
        public EmployeeBaseCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBaseCollection"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        public EmployeeBaseCollection(IEnumerable<EmployeeBase> collection) => AddRange(collection);
    }

    /// <summary>
    /// Represents the <see cref="EmployeeBase"/> collection result.
    /// </summary>
    public class EmployeeBaseCollectionResult : EntityCollectionResult<EmployeeBaseCollection, EmployeeBase, EmployeeBaseCollectionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBaseCollectionResult"/> class.
        /// </summary>
        public EmployeeBaseCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBaseCollectionResult"/> class with <paramref name="paging"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public EmployeeBaseCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBaseCollectionResult"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        /// <param name="paging">The optional <see cref="PagingArgs"/>.</param>
        public EmployeeBaseCollectionResult(IEnumerable<EmployeeBase> collection, PagingArgs? paging = null) : base(paging) => Collection.AddRange(collection);
    }
}

#pragma warning restore
#nullable restore