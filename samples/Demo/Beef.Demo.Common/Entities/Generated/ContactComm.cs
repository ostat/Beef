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
    /// Represents the <see cref="Contact"/> Comm entity.
    /// </summary>
    public partial class ContactComm
    {
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// Indicates whether Communication is the preferred (only one).
        /// </summary>
        public bool IsPreferred { get; set; }
    }

    /// <summary>
    /// Represents the <see cref="ContactComm"/> collection.
    /// </summary>
    public partial class ContactCommCollection : Dictionary<string, ContactComm> { }
}

#pragma warning restore
#nullable restore