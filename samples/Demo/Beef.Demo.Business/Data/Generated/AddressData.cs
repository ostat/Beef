/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Data
{
    /// <summary>
    /// Provides the <see cref="Address"/> data access.
    /// </summary>
    public partial class AddressData
    {

        /// <summary>
        /// Provides the <see cref="Address"/> property and database column mapping.
        /// </summary>
        public partial class DbMapper : DatabaseMapper<Address, DbMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DbMapper"/> class.
            /// </summary>
            public DbMapper()
            {
                Property(s => s.Street);
                Property(s => s.City);
                DbMapperCtor();
            }
            
            partial void DbMapperCtor(); // Enables the DbMapper constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore