/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using CoreEx.Entities;

namespace Cdr.Banking.Common.Entities
{
    /// <summary>
    /// Represents the Account entity.
    /// </summary>
    public partial class Account : IIdentifier<string>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonPropertyName("accountId")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the Creation Date.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the Display Name.
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the Nickname.
        /// </summary>
        public string? Nickname { get; set; }

        /// <summary>
        /// Gets or sets the Open Status.
        /// </summary>
        public string? OpenStatus { get; set; }

        /// <summary>
        /// Indicates whether Is Owned.
        /// </summary>
        public bool IsOwned { get; set; }

        /// <summary>
        /// Gets or sets the Masked Number.
        /// </summary>
        public string? MaskedNumber { get; set; }

        /// <summary>
        /// Gets or sets the Product Category.
        /// </summary>
        public string? ProductCategory { get; set; }

        /// <summary>
        /// Gets or sets the Product Name.
        /// </summary>
        public string? ProductName { get; set; }
    }

    /// <summary>
    /// Represents the <see cref="Account"/> collection.
    /// </summary>
    public partial class AccountCollection : List<Account> { }

    /// <summary>
    /// Represents the <see cref="Account"/> collection result.
    /// </summary>
    public class AccountCollectionResult : CollectionResult<AccountCollection, Account>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCollectionResult"/> class.
        /// </summary>
        public AccountCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCollectionResult"/> class with <paramref name="paging"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public AccountCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCollectionResult"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public AccountCollectionResult(IEnumerable<Account> items, PagingArgs? paging = null) : base(paging) => Items.AddRange(items);
    }
}