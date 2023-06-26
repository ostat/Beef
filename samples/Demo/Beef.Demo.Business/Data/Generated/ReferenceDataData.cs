/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Data;

/// <summary>
/// Provides the <b>ReferenceData</b> data access.
/// </summary>
public partial class ReferenceDataData : IReferenceDataData
{
    private readonly IDatabase _db;
    private readonly IEfDb _ef;
    private readonly DemoCosmosDb _cosmos;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReferenceDataData"/> class.
    /// </summary>
    /// <param name="db">The <see cref="IDatabase"/>.</param>
    /// <param name="ef">The <see cref="IEfDb"/>.</param>
    /// <param name="cosmos">The <see cref="DemoCosmosDb"/>.</param>
    /// <param name="mapper">The <see cref="IMapper"/>.</param>
    public ReferenceDataData(IDatabase db, IEfDb ef, DemoCosmosDb cosmos, IMapper mapper)
        { _db = db.ThrowIfNull(); _ef = ef.ThrowIfNull(); _cosmos = cosmos.ThrowIfNull(); _mapper = mapper.ThrowIfNull(); ReferenceDataDataCtor(); }

    partial void ReferenceDataDataCtor(); // Enables additional functionality to be added to the constructor.

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.CountryCollection>> CountryGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, ct => _db.ReferenceData<RefDataNamespace.CountryCollection, RefDataNamespace.Country, Guid>("[Ref].[spCountryGetAll]").LoadWithResultAsync("CountryId"), InvokerArgs.TransactionSuppress);

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.USStateCollection>> USStateGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, ct => _db.ReferenceData<RefDataNamespace.USStateCollection, RefDataNamespace.USState, Guid>("[Ref].[spUSStateGetAll]").LoadWithResultAsync("USStateId"), InvokerArgs.TransactionSuppress);

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.GenderCollection>> GenderGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, ct => 
        {
            return _db.ReferenceData<RefDataNamespace.GenderCollection, RefDataNamespace.Gender, Guid>("[Ref].[spGenderGetAll]").LoadWithResultAsync("GenderId", additionalProperties: (dr, item) =>
            {
                item.AlternateName = dr.GetValue<string>("AlternateName");
                item.TripCode = dr.GetValue<string>("TripCode");
                item.Country = ReferenceDataIdConverter<RefDataNamespace.Country, Guid?>.Default.ToSource.Convert(dr.GetValue<Guid?>("CountryId"));
            }, cancellationToken: ct);
        }, InvokerArgs.TransactionSuppress);

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.EyeColorCollection>> EyeColorGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, ct => _ef.Query<RefDataNamespace.EyeColor, EfModel.EyeColor>().SelectQueryWithResultAsync<RefDataNamespace.EyeColorCollection>(ct), InvokerArgs.TransactionSuppress);

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.PowerSourceCollection>> PowerSourceGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, ct => _cosmos.ValueContainer<RefDataNamespace.PowerSource, Model.PowerSource>("RefData").Query().SelectQueryWithResultAsync<RefDataNamespace.PowerSourceCollection>(ct));

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.CompanyCollection>> CompanyGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, _ => CompanyGetAll_OnImplementationAsync());

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.StatusCollection>> StatusGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, ct => _ef.Query<RefDataNamespace.Status, EfModel.Status>().SelectQueryWithResultAsync<RefDataNamespace.StatusCollection>(ct), InvokerArgs.TransactionSuppress);

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.CommunicationTypeCollection>> CommunicationTypeGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, _ => CommunicationTypeGetAll_OnImplementationAsync());

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.EyeColor"/> to Entity Framework <see cref="EfModel.EyeColor"/> mapping.
    /// </summary>
    public partial class EyeColorToModelEfMapper : Mapper<RefDataNamespace.EyeColor, EfModel.EyeColor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EyeColorToModelEfMapper"/> class.
        /// </summary>
        public EyeColorToModelEfMapper()
        {
            Map((s, d) => d.EyeColorId = s.Id, OperationTypes.Any, s => s.Id == default, d => d.EyeColorId = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag), OperationTypes.Any, s => s.ETag == default, d => d.RowVersion = default);
            EyeColorToModelEfMapperCtor();
        }

        partial void EyeColorToModelEfMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="EfModel.EyeColor"/> to <see cref="RefDataNamespace.EyeColor"/> mapping.
    /// </summary>
    public partial class ModelToEyeColorEfMapper : Mapper<EfModel.EyeColor, RefDataNamespace.EyeColor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
        /// </summary>
        public ModelToEyeColorEfMapper()
        {
            Map((s, d) => d.Id = (Guid)s.EyeColorId!, OperationTypes.Any, s => s.EyeColorId == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion!), OperationTypes.Any, s => s.RowVersion == default, d => d.ETag = default);
            ModelToEyeColorEfMapperCtor();
        }

        partial void ModelToEyeColorEfMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.PowerSource"/> to Entity Framework <see cref="Model.PowerSource"/> mapping.
    /// </summary>
    public partial class PowerSourceToModelCosmosMapper : Mapper<RefDataNamespace.PowerSource, Model.PowerSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerSourceToModelCosmosMapper"/> class.
        /// </summary>
        public PowerSourceToModelCosmosMapper()
        {
            Map((s, d) => d.Id = s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = s.ETag, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            Map((s, d) => d.AdditionalInfo = s.AdditionalInfo, OperationTypes.Any, s => s.AdditionalInfo == default, d => d.AdditionalInfo = default);
            PowerSourceToModelCosmosMapperCtor();
        }

        partial void PowerSourceToModelCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="Model.PowerSource"/> to <see cref="RefDataNamespace.PowerSource"/> mapping.
    /// </summary>
    public partial class ModelToPowerSourceCosmosMapper : Mapper<Model.PowerSource, RefDataNamespace.PowerSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityCosmosMapper"/> class.
        /// </summary>
        public ModelToPowerSourceCosmosMapper()
        {
            Map((s, d) => d.Id = (Guid)s.Id!, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)s.ETag!, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            Map((s, d) => d.AdditionalInfo = (string?)s.AdditionalInfo!, OperationTypes.Any, s => s.AdditionalInfo == default, d => d.AdditionalInfo = default);
            ModelToPowerSourceCosmosMapperCtor();
        }

        partial void ModelToPowerSourceCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.Status"/> to Entity Framework <see cref="EfModel.Status"/> mapping.
    /// </summary>
    public partial class StatusToModelEfMapper : Mapper<RefDataNamespace.Status, EfModel.Status>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusToModelEfMapper"/> class.
        /// </summary>
        public StatusToModelEfMapper()
        {
            Map((s, d) => d.StatusId = s.Id, OperationTypes.Any, s => s.Id == default, d => d.StatusId = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag), OperationTypes.Any, s => s.ETag == default, d => d.RowVersion = default);
            StatusToModelEfMapperCtor();
        }

        partial void StatusToModelEfMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="EfModel.Status"/> to <see cref="RefDataNamespace.Status"/> mapping.
    /// </summary>
    public partial class ModelToStatusEfMapper : Mapper<EfModel.Status, RefDataNamespace.Status>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
        /// </summary>
        public ModelToStatusEfMapper()
        {
            Map((s, d) => d.Id = (string?)s.StatusId!, OperationTypes.Any, s => s.StatusId == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion!), OperationTypes.Any, s => s.RowVersion == default, d => d.ETag = default);
            ModelToStatusEfMapperCtor();
        }

        partial void ModelToStatusEfMapperCtor(); // Enables the constructor to be extended.
    }
}

#pragma warning restore
#nullable restore