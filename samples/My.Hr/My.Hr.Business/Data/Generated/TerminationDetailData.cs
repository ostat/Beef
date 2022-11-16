/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace My.Hr.Business.Data
{
    /// <summary>
    /// Provides the <see cref="TerminationDetail"/> data access.
    /// </summary>
    public partial class TerminationDetailData
    {

        /// <summary>
        /// Provides the <see cref="TerminationDetail"/> property and database column mapping.
        /// </summary>
        public partial class DbMapper : DatabaseMapper<TerminationDetail, DbMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DbMapper"/> class.
            /// </summary>
            public DbMapper()
            {
                Property(s => s.Date, "TerminationDate");
                Property(s => s.ReasonSid, "TerminationReasonCode");
                DbMapperCtor();
            }
            
            partial void DbMapperCtor(); // Enables the DbMapper constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="TerminationDetail"/> to Entity Framework <see cref="EfModel.Employee"/> mapping.
        /// </summary>
        public partial class EntityToModelEfMapper : Mapper<TerminationDetail, EfModel.Employee>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="EntityToModelEfMapper"/> class.
            /// </summary>
            public EntityToModelEfMapper()
            {
                Map((s, d) => d.TerminationDate = s.Date);
                Map((s, d) => d.TerminationReasonCode = s.ReasonSid);
                EntityToModelEfMapperCtor();
            }

            partial void EntityToModelEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the Entity Framework <see cref="EfModel.Employee"/> to <see cref="TerminationDetail"/> mapping.
        /// </summary>
        public partial class ModelToEntityEfMapper : Mapper<EfModel.Employee, TerminationDetail>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
            /// </summary>
            public ModelToEntityEfMapper()
            {
                Map((s, d) => d.Date = (DateTime)s.TerminationDate);
                Map((s, d) => d.ReasonSid = (string?)s.TerminationReasonCode);
                ModelToEntityEfMapperCtor();
            }

            /// <inheritdoc/>
            public override bool IsSourceInitial(EfModel.Employee s)
                => s.TerminationDate == default
                && s.TerminationReasonCode == default;

            partial void ModelToEntityEfMapperCtor(); // Enables the constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore