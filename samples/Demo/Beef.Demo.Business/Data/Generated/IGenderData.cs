/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Data;

/// <summary>
/// Defines the <see cref="Gender"/> data access.
/// </summary>
public partial interface IGenderData
{
    /// <summary>
    /// Gets the specified <see cref="Gender"/>.
    /// </summary>
    /// <param name="id">The <see cref="Gender"/> identifier.</param>
    /// <returns>The selected <see cref="Gender"/> where found.</returns>
    Task<Result<Gender?>> GetAsync(Guid id);

    /// <summary>
    /// Creates a new <see cref="Gender"/>.
    /// </summary>
    /// <param name="value">The <see cref="Gender"/>.</param>
    /// <returns>The created <see cref="Gender"/>.</returns>
    Task<Result<Gender>> CreateAsync(Gender value);

    /// <summary>
    /// Updates an existing <see cref="Gender"/>.
    /// </summary>
    /// <param name="value">The <see cref="Gender"/>.</param>
    /// <returns>The updated <see cref="Gender"/>.</returns>
    Task<Result<Gender>> UpdateAsync(Gender value);
}

#pragma warning restore
#nullable restore