/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace My.Hr.Business.Data
{
    /// <summary>
    /// Provides the <b>ReferenceData</b> data access.
    /// </summary>
    public partial class ReferenceDataData : IReferenceDataData
    {
        private readonly IEfDb _ef;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDataData"/> class.
        /// </summary>
        /// <param name="ef">The <see cref="IEfDb"/>.</param>
        public ReferenceDataData(IEfDb ef)
            { _ef = ef ?? throw new ArgumentNullException(nameof(ef)); ReferenceDataDataCtor(); }

        partial void ReferenceDataDataCtor(); // Enables additional functionality to be added to the constructor.

        /// <inheritdoc/>
        public Task<RefDataNamespace.GenderCollection> GenderGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.Gender, EfModel.Gender>().SelectQueryAsync<RefDataNamespace.GenderCollection>(), InvokerArgs.TransactionSuppress);

        /// <inheritdoc/>
        public Task<RefDataNamespace.TerminationReasonCollection> TerminationReasonGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.TerminationReason, EfModel.TerminationReason>().SelectQueryAsync<RefDataNamespace.TerminationReasonCollection>(), InvokerArgs.TransactionSuppress);

        /// <inheritdoc/>
        public Task<RefDataNamespace.RelationshipTypeCollection> RelationshipTypeGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.RelationshipType, EfModel.RelationshipType>().SelectQueryAsync<RefDataNamespace.RelationshipTypeCollection>(), InvokerArgs.TransactionSuppress);

        /// <inheritdoc/>
        public Task<RefDataNamespace.USStateCollection> USStateGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.USState, EfModel.USState>().SelectQueryAsync<RefDataNamespace.USStateCollection>(), InvokerArgs.TransactionSuppress);

        /// <inheritdoc/>
        public Task<RefDataNamespace.PerformanceOutcomeCollection> PerformanceOutcomeGetAllAsync()
            => DataInvoker.Current.InvokeAsync(this, _ =>_ef.Query<RefDataNamespace.PerformanceOutcome, EfModel.PerformanceOutcome>().SelectQueryAsync<RefDataNamespace.PerformanceOutcomeCollection>(), InvokerArgs.TransactionSuppress);

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.Gender"/> to Entity Framework <see cref="EfModel.Gender"/> mapping.
        /// </summary>
        public partial class GenderToModelEfMapper : Mapper<RefDataNamespace.Gender, EfModel.Gender>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="GenderToModelEfMapper"/> class.
            /// </summary>
            public GenderToModelEfMapper()
            {
                Map((s, d) => d.GenderId = s.Id);
                Map((s, d) => d.Code = s.Code);
                Map((s, d) => d.Text = s.Text);
                Map((s, d) => d.IsActive = s.IsActive);
                Map((s, d) => d.SortOrder = s.SortOrder);
                Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag));
                GenderToModelEfMapperCtor();
            }

            partial void GenderToModelEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the Entity Framework <see cref="EfModel.Gender"/> to <see cref="RefDataNamespace.Gender"/> mapping.
        /// </summary>
        public partial class ModelToGenderEfMapper : Mapper<EfModel.Gender, RefDataNamespace.Gender>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
            /// </summary>
            public ModelToGenderEfMapper()
            {
                Map((s, d) => d.Id = (Guid)s.GenderId);
                Map((s, d) => d.Code = (string?)s.Code);
                Map((s, d) => d.Text = (string?)s.Text);
                Map((s, d) => d.IsActive = (bool)s.IsActive);
                Map((s, d) => d.SortOrder = (int)s.SortOrder);
                Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion));
                ModelToGenderEfMapperCtor();
            }

            partial void ModelToGenderEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.TerminationReason"/> to Entity Framework <see cref="EfModel.TerminationReason"/> mapping.
        /// </summary>
        public partial class TerminationReasonToModelEfMapper : Mapper<RefDataNamespace.TerminationReason, EfModel.TerminationReason>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="TerminationReasonToModelEfMapper"/> class.
            /// </summary>
            public TerminationReasonToModelEfMapper()
            {
                Map((s, d) => d.TerminationReasonId = s.Id);
                Map((s, d) => d.Code = s.Code);
                Map((s, d) => d.Text = s.Text);
                Map((s, d) => d.IsActive = s.IsActive);
                Map((s, d) => d.SortOrder = s.SortOrder);
                Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag));
                TerminationReasonToModelEfMapperCtor();
            }

            partial void TerminationReasonToModelEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the Entity Framework <see cref="EfModel.TerminationReason"/> to <see cref="RefDataNamespace.TerminationReason"/> mapping.
        /// </summary>
        public partial class ModelToTerminationReasonEfMapper : Mapper<EfModel.TerminationReason, RefDataNamespace.TerminationReason>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
            /// </summary>
            public ModelToTerminationReasonEfMapper()
            {
                Map((s, d) => d.Id = (Guid)s.TerminationReasonId);
                Map((s, d) => d.Code = (string?)s.Code);
                Map((s, d) => d.Text = (string?)s.Text);
                Map((s, d) => d.IsActive = (bool)s.IsActive);
                Map((s, d) => d.SortOrder = (int)s.SortOrder);
                Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion));
                ModelToTerminationReasonEfMapperCtor();
            }

            partial void ModelToTerminationReasonEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.RelationshipType"/> to Entity Framework <see cref="EfModel.RelationshipType"/> mapping.
        /// </summary>
        public partial class RelationshipTypeToModelEfMapper : Mapper<RefDataNamespace.RelationshipType, EfModel.RelationshipType>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="RelationshipTypeToModelEfMapper"/> class.
            /// </summary>
            public RelationshipTypeToModelEfMapper()
            {
                Map((s, d) => d.RelationshipTypeId = s.Id);
                Map((s, d) => d.Code = s.Code);
                Map((s, d) => d.Text = s.Text);
                Map((s, d) => d.IsActive = s.IsActive);
                Map((s, d) => d.SortOrder = s.SortOrder);
                Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag));
                RelationshipTypeToModelEfMapperCtor();
            }

            partial void RelationshipTypeToModelEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the Entity Framework <see cref="EfModel.RelationshipType"/> to <see cref="RefDataNamespace.RelationshipType"/> mapping.
        /// </summary>
        public partial class ModelToRelationshipTypeEfMapper : Mapper<EfModel.RelationshipType, RefDataNamespace.RelationshipType>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
            /// </summary>
            public ModelToRelationshipTypeEfMapper()
            {
                Map((s, d) => d.Id = (Guid)s.RelationshipTypeId);
                Map((s, d) => d.Code = (string?)s.Code);
                Map((s, d) => d.Text = (string?)s.Text);
                Map((s, d) => d.IsActive = (bool)s.IsActive);
                Map((s, d) => d.SortOrder = (int)s.SortOrder);
                Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion));
                ModelToRelationshipTypeEfMapperCtor();
            }

            partial void ModelToRelationshipTypeEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.USState"/> to Entity Framework <see cref="EfModel.USState"/> mapping.
        /// </summary>
        public partial class USStateToModelEfMapper : Mapper<RefDataNamespace.USState, EfModel.USState>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="USStateToModelEfMapper"/> class.
            /// </summary>
            public USStateToModelEfMapper()
            {
                Map((s, d) => d.USStateId = s.Id);
                Map((s, d) => d.Code = s.Code);
                Map((s, d) => d.Text = s.Text);
                Map((s, d) => d.IsActive = s.IsActive);
                Map((s, d) => d.SortOrder = s.SortOrder);
                Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag));
                USStateToModelEfMapperCtor();
            }

            partial void USStateToModelEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the Entity Framework <see cref="EfModel.USState"/> to <see cref="RefDataNamespace.USState"/> mapping.
        /// </summary>
        public partial class ModelToUSStateEfMapper : Mapper<EfModel.USState, RefDataNamespace.USState>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
            /// </summary>
            public ModelToUSStateEfMapper()
            {
                Map((s, d) => d.Id = (Guid)s.USStateId);
                Map((s, d) => d.Code = (string?)s.Code);
                Map((s, d) => d.Text = (string?)s.Text);
                Map((s, d) => d.IsActive = (bool)s.IsActive);
                Map((s, d) => d.SortOrder = (int)s.SortOrder);
                Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion));
                ModelToUSStateEfMapperCtor();
            }

            partial void ModelToUSStateEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.PerformanceOutcome"/> to Entity Framework <see cref="EfModel.PerformanceOutcome"/> mapping.
        /// </summary>
        public partial class PerformanceOutcomeToModelEfMapper : Mapper<RefDataNamespace.PerformanceOutcome, EfModel.PerformanceOutcome>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="PerformanceOutcomeToModelEfMapper"/> class.
            /// </summary>
            public PerformanceOutcomeToModelEfMapper()
            {
                Map((s, d) => d.PerformanceOutcomeId = s.Id);
                Map((s, d) => d.Code = s.Code);
                Map((s, d) => d.Text = s.Text);
                Map((s, d) => d.IsActive = s.IsActive);
                Map((s, d) => d.SortOrder = s.SortOrder);
                Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag));
                PerformanceOutcomeToModelEfMapperCtor();
            }

            partial void PerformanceOutcomeToModelEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the Entity Framework <see cref="EfModel.PerformanceOutcome"/> to <see cref="RefDataNamespace.PerformanceOutcome"/> mapping.
        /// </summary>
        public partial class ModelToPerformanceOutcomeEfMapper : Mapper<EfModel.PerformanceOutcome, RefDataNamespace.PerformanceOutcome>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
            /// </summary>
            public ModelToPerformanceOutcomeEfMapper()
            {
                Map((s, d) => d.Id = (Guid)s.PerformanceOutcomeId);
                Map((s, d) => d.Code = (string?)s.Code);
                Map((s, d) => d.Text = (string?)s.Text);
                Map((s, d) => d.IsActive = (bool)s.IsActive);
                Map((s, d) => d.SortOrder = (int)s.SortOrder);
                Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion));
                ModelToPerformanceOutcomeEfMapperCtor();
            }

            partial void ModelToPerformanceOutcomeEfMapperCtor(); // Enables the constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore