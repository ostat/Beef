/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using CoreEx.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the Product entity.
    /// </summary>
    public partial class Product : IPrimaryKey
    {
        /// <summary>
        /// Gets or sets the <see cref="Product"/> identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string? Description { get; set; }
        
        /// <summary>
        /// Creates the primary <see cref="CompositeKey"/>.
        /// </summary>
        /// <returns>The primary <see cref="CompositeKey"/>.</returns>
        /// <param name="id">The <see cref="Id"/>.</param>
        public static CompositeKey CreatePrimaryKey(int id) => new CompositeKey(id);

        /// <summary>
        /// Gets the primary <see cref="CompositeKey"/> (consists of the following property(s): <see cref="Id"/>).
        /// </summary>
        [JsonIgnore]
        public CompositeKey PrimaryKey => CreatePrimaryKey(Id);
    }

    /// <summary>
    /// Represents the <see cref="Product"/> collection.
    /// </summary>
    public partial class ProductCollection : List<Product> { }

    /// <summary>
    /// Represents the <see cref="Product"/> collection result.
    /// </summary>
    public class ProductCollectionResult : CollectionResult<ProductCollection, Product>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCollectionResult"/> class.
        /// </summary>
        public ProductCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCollectionResult"/> class with <paramref name="paging"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public ProductCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCollectionResult"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public ProductCollectionResult(IEnumerable<Product> collection, PagingArgs? paging = null) : base(paging) => Collection.AddRange(collection);
    }
}

#pragma warning restore
#nullable restore