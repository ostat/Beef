/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business;

/// <summary>
/// Defines the <b>Config</b> business functionality.
/// </summary>
public partial interface IConfigManager
{
    /// <summary>
    /// Get Env Vars.
    /// </summary>
    /// <returns>A resultant <see cref="System.Collections.IDictionary"/>.</returns>
    Task<System.Collections.IDictionary> GetEnvVarsAsync();
}

#pragma warning restore
#nullable restore