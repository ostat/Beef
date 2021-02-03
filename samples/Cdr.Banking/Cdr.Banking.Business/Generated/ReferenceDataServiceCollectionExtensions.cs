/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using Microsoft.Extensions.DependencyInjection;
using Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Business
{
    /// <summary>
    /// Provides the generated <b>Manager</b>-layer services.
    /// </summary>
    public static class ReferenceDataServiceCollectionsExtension
    {
        /// <summary>
        /// Adds the generated <b>Manager</b>-layer services.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddGeneratedReferenceDataManagerServices(this IServiceCollection services)
        {
            return services.AddSingleton<IReferenceData, ReferenceDataProvider>();
        }
    }
}

#pragma warning restore
#nullable restore