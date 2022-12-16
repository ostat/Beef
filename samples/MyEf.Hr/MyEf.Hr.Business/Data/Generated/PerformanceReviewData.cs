/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace MyEf.Hr.Business.Data
{
    /// <summary>
    /// Provides the <see cref="PerformanceReview"/> data access.
    /// </summary>
    public partial class PerformanceReviewData : IPerformanceReviewData
    {
        private readonly IEfDb _ef;
        private Func<IQueryable<EfModel.PerformanceReview>, Guid, IQueryable<EfModel.PerformanceReview>>? _getByEmployeeIdOnQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReviewData"/> class.
        /// </summary>
        /// <param name="ef">The <see cref="IEfDb"/>.</param>
        public PerformanceReviewData(IEfDb ef)
            { _ef = ef ?? throw new ArgumentNullException(nameof(ef)); PerformanceReviewDataCtor(); }

        partial void PerformanceReviewDataCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="PerformanceReview"/>.
        /// </summary>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        /// <returns>The selected <see cref="PerformanceReview"/> where found.</returns>
        public Task<PerformanceReview?> GetAsync(Guid id)
        {
            return _ef.GetAsync<PerformanceReview, EfModel.PerformanceReview>(id);
        }

        /// <summary>
        /// Gets the <see cref="PerformanceReviewCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="employeeId">The <see cref="Employee.Id"/>.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="PerformanceReviewCollectionResult"/>.</returns>
        public Task<PerformanceReviewCollectionResult> GetByEmployeeIdAsync(Guid employeeId, PagingArgs? paging)
        {
            return _ef.Query<PerformanceReview, EfModel.PerformanceReview>(q => _getByEmployeeIdOnQuery?.Invoke(q, employeeId) ?? q).WithPaging(paging).SelectResultAsync<PerformanceReviewCollectionResult, PerformanceReviewCollection>();
        }

        /// <summary>
        /// Creates a new <see cref="PerformanceReview"/>.
        /// </summary>
        /// <param name="value">The <see cref="PerformanceReview"/>.</param>
        /// <returns>The created <see cref="PerformanceReview"/>.</returns>
        public Task<PerformanceReview> CreateAsync(PerformanceReview value)
        {
            return _ef.CreateAsync<PerformanceReview, EfModel.PerformanceReview>(value ?? throw new ArgumentNullException(nameof(value)));
        }

        /// <summary>
        /// Updates an existing <see cref="PerformanceReview"/>.
        /// </summary>
        /// <param name="value">The <see cref="PerformanceReview"/>.</param>
        /// <returns>The updated <see cref="PerformanceReview"/>.</returns>
        public Task<PerformanceReview> UpdateAsync(PerformanceReview value)
        {
            return _ef.UpdateAsync<PerformanceReview, EfModel.PerformanceReview>(value ?? throw new ArgumentNullException(nameof(value)));
        }

        /// <summary>
        /// Deletes the specified <see cref="PerformanceReview"/>.
        /// </summary>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        public Task DeleteAsync(Guid id)
        {
            return _ef.DeleteAsync<PerformanceReview, EfModel.PerformanceReview>(id);
        }

        /// <summary>
        /// Provides the <see cref="PerformanceReview"/> to Entity Framework <see cref="EfModel.PerformanceReview"/> mapping.
        /// </summary>
        public partial class EntityToModelEfMapper : Mapper<PerformanceReview, EfModel.PerformanceReview>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="EntityToModelEfMapper"/> class.
            /// </summary>
            public EntityToModelEfMapper()
            {
                Map((s, d) => d.PerformanceReviewId = s.Id);
                Map((s, d) => d.EmployeeId = s.EmployeeId, OperationTypes.AnyExceptUpdate);
                Map((s, d) => d.Date = s.Date);
                Map((s, d) => d.PerformanceOutcomeCode = s.OutcomeSid);
                Map((s, d) => d.Reviewer = s.Reviewer);
                Map((s, d) => d.Notes = s.Notes);
                Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag));
                Flatten(s => s.ChangeLog);
                EntityToModelEfMapperCtor();
            }

            /// <inheritdoc/>
            public override bool IsSourceInitial(PerformanceReview s)
                => s.Id == default
                && s.EmployeeId == default
                && s.Date == default
                && s.OutcomeSid == default
                && s.Reviewer == default
                && s.Notes == default
                && s.ETag == default
                && s.ChangeLog == default;

            /// <inheritdoc/>
            protected override void OnRegister(Mapper<PerformanceReview, EfModel.PerformanceReview> mapper) => mapper.Owner.Register(new Mapper<ChangeLogEx, EfModel.PerformanceReview>()
                .Map((s, d) => d.CreatedBy = s.CreatedBy, OperationTypes.AnyExceptUpdate)
                .Map((s, d) => d.CreatedDate = s.CreatedDate, OperationTypes.AnyExceptUpdate)
                .Map((s, d) => d.UpdatedBy = s.UpdatedBy, OperationTypes.AnyExceptCreate)
                .Map((s, d) => d.UpdatedDate = s.UpdatedDate, OperationTypes.AnyExceptCreate));

            partial void EntityToModelEfMapperCtor(); // Enables the constructor to be extended.
        }

        /// <summary>
        /// Provides the Entity Framework <see cref="EfModel.PerformanceReview"/> to <see cref="PerformanceReview"/> mapping.
        /// </summary>
        public partial class ModelToEntityEfMapper : Mapper<EfModel.PerformanceReview, PerformanceReview>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
            /// </summary>
            public ModelToEntityEfMapper()
            {
                Map((s, d) => d.Id = (Guid)s.PerformanceReviewId);
                Map((s, d) => d.EmployeeId = (Guid)s.EmployeeId, OperationTypes.AnyExceptUpdate);
                Map((s, d) => d.Date = (DateTime)s.Date);
                Map((s, d) => d.OutcomeSid = (string?)s.PerformanceOutcomeCode);
                Map((s, d) => d.Reviewer = (string?)s.Reviewer);
                Map((s, d) => d.Notes = (string?)s.Notes);
                Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion));
                Expand<ChangeLogEx>((d, v) => d.ChangeLog = v);
                ModelToEntityEfMapperCtor();
            }

            /// <inheritdoc/>
            public override bool IsSourceInitial(EfModel.PerformanceReview s)
                => s.PerformanceReviewId == default
                && s.EmployeeId == default
                && s.Date == default
                && s.PerformanceOutcomeCode == default
                && s.Reviewer == default
                && s.Notes == default
                && s.RowVersion == default;

            /// <inheritdoc/>
            protected override void OnRegister(Mapper<EfModel.PerformanceReview, PerformanceReview> mapper) => mapper.Owner.Register(new Mapper<EfModel.PerformanceReview, ChangeLogEx>()
                .Map((s, d) => d.CreatedBy = s.CreatedBy, OperationTypes.AnyExceptUpdate)
                .Map((s, d) => d.CreatedDate = s.CreatedDate, OperationTypes.AnyExceptUpdate)
                .Map((s, d) => d.UpdatedBy = s.UpdatedBy, OperationTypes.AnyExceptCreate)
                .Map((s, d) => d.UpdatedDate = s.UpdatedDate, OperationTypes.AnyExceptCreate));

            partial void ModelToEntityEfMapperCtor(); // Enables the constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore