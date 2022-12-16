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

namespace MyEf.Hr.Common.Entities
{
    /// <summary>
    /// Represents the <see cref="Employee"/> search arguments entity.
    /// </summary>
    public partial class EmployeeArgs
    {
        /// <summary>
        /// Gets or sets the First Name.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Last Name.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the Genders.
        /// </summary>
        public List<string?>? Genders { get; set; }

        /// <summary>
        /// Gets or sets the Start From.
        /// </summary>
        public DateTime? StartFrom { get; set; }

        /// <summary>
        /// Gets or sets the Start To.
        /// </summary>
        public DateTime? StartTo { get; set; }

        /// <summary>
        /// Indicates whether Is Include Terminated.
        /// </summary>
        [JsonPropertyName("includeTerminated")]
        public bool? IsIncludeTerminated { get; set; }
    }
}

#pragma warning restore
#nullable restore