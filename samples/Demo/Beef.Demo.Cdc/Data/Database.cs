﻿using Beef.Data.Database;
using System.Data.Common;

namespace Beef.Demo.Cdc.Data
{
    /// <summary>
    /// Represents the <b>Beef.Demo</b> database.
    /// </summary>
    public class Database : DatabaseBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="provider">The optional data provider.</param>
        public Database(string connectionString, DbProviderFactory provider = null) : base(connectionString, provider, new SqlRetryDatabaseInvoker()) { }
    }
}