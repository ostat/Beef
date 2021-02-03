/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Data;
using Beef.Data.Database;
using Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.Data
{
    public partial class WorkHistoryData
    {
        public partial class DbMapper
        {
            /// <summary>
            /// Creates a <see cref="TableValuedParameter"/> for the <paramref name="list"/>.
            /// </summary>
            /// <param name="list">The entity list.</param>
            /// <returns>The Table-Valued Parameter.</returns>
            public TableValuedParameter CreateTableValuedParameter(IEnumerable<WorkHistory> list)
            {        
                var dt = new DataTable();
                dt.Columns.Add("WorkHistoryId", typeof(Guid));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("StartDate", typeof(DateTime));
                dt.Columns.Add("EndDate", typeof(DateTime));

                var tvp = new TableValuedParameter("[Demo].[udtWorkHistoryList]", dt);
                AddToTableValuedParameter(tvp, list);
                return tvp;
            }
        }
    }
}

#pragma warning restore
#nullable restore