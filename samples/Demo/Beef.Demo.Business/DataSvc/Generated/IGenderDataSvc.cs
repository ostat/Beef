/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Entities;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.DataSvc
{
    /// <summary>
    /// Defines the <see cref="Gender"/> data repository services.
    /// </summary>
    public partial interface IGenderDataSvc
    {
        /// <summary>
        /// Gets the specified <see cref="Gender"/>.
        /// </summary>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <returns>The selected <see cref="Gender"/> where found.</returns>
        Task<Gender?> GetAsync(Guid id);

        /// <summary>
        /// Creates a new <see cref="Gender"/>.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/>.</param>
        /// <returns>The created <see cref="Gender"/>.</returns>
        Task<Gender> CreateAsync(Gender value);

        /// <summary>
        /// Updates an existing <see cref="Gender"/>.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/>.</param>
        /// <returns>The updated <see cref="Gender"/>.</returns>
        Task<Gender> UpdateAsync(Gender value);
    }
}

#pragma warning restore
#nullable restore