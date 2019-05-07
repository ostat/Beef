/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Entities;
using Beef.Demo.Business.Data;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.DataSvc
{
    /// <summary>
    /// Provides the Gender data repository services.
    /// </summary>
    public static partial class GenderDataSvc
    {
        /// <summary>
        /// Gets the <see cref="Gender"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <returns>The selected <see cref="Gender"/> object where found; otherwise, <c>null</c>.</returns>
        public static Task<Gender> GetAsync(Guid id)
        {
            return DataSvcInvoker<Gender>.Default.InvokeAsync(typeof(GenderDataSvc), async () => 
            {
                var __key = new UniqueKey(id);
                if (ExecutionContext.Current.TryGetCacheValue<Gender>(__key, out Gender __val))
                    return __val;

                var __result = await Factory.Create<IGenderData>().GetAsync(id);
                ExecutionContext.Current.CacheSet<Gender>(__key, __result);
                return __result;
            });
        }      

        /// <summary>
        /// Creates the <see cref="Gender"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/> object.</param>
        /// <returns>A refreshed <see cref="Gender"/> object.</returns>
        public static Task<Gender> CreateAsync(Gender value)
        {
            return DataSvcInvoker<Gender>.Default.InvokeAsync(typeof(GenderDataSvc), async () => 
            {
                var __result = await Factory.Create<IGenderData>().CreateAsync(value);
                await Beef.Events.Event.PublishAsync(__result, "Demo.Gender.{id}", "Create", new KeyValuePair<string, object>("id", __result.Id));
                ExecutionContext.Current.CacheSet<Gender>(__result?.UniqueKey ?? UniqueKey.Empty, __result);
                return __result;
            });
        }      

        /// <summary>
        /// Updates the <see cref="Gender"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/> object.</param>
        /// <returns>A refreshed <see cref="Gender"/> object.</returns>
        public static Task<Gender> UpdateAsync(Gender value)
        {
            return DataSvcInvoker<Gender>.Default.InvokeAsync(typeof(GenderDataSvc), async () => 
            {
                var __result = await Factory.Create<IGenderData>().UpdateAsync(value);
                await Beef.Events.Event.PublishAsync(__result, "Demo.Gender.{id}", "Update", new KeyValuePair<string, object>("id", __result.Id));
                ExecutionContext.Current.CacheSet<Gender>(__result?.UniqueKey ?? UniqueKey.Empty, __result);
                return __result;
            });
        }      
    }
}