/*
 * This file is automatically generated; any changes will be lost. 
 */

namespace Cdr.Banking.Business.Data;

/// <summary>
/// Provides the <b>ReferenceData</b> data access.
/// </summary>
public partial class ReferenceDataData : IReferenceDataData
{
    private readonly ICosmos _cosmos;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReferenceDataData"/> class.
    /// </summary>
    /// <param name="cosmos">The <see cref="ICosmos"/>.</param>
    public ReferenceDataData(ICosmos cosmos)
        { _cosmos = cosmos.ThrowIfNull(); ReferenceDataDataCtor(); }

    partial void ReferenceDataDataCtor(); // Enables additional functionality to be added to the constructor.

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.OpenStatusCollection>> OpenStatusGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, (_, ct) => _cosmos.ValueContainer<RefDataNamespace.OpenStatus, Model.OpenStatus>("RefData").Query().SelectQueryWithResultAsync<RefDataNamespace.OpenStatusCollection>(ct));

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.ProductCategoryCollection>> ProductCategoryGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, (_, ct) => _cosmos.ValueContainer<RefDataNamespace.ProductCategory, Model.ProductCategory>("RefData").Query().SelectQueryWithResultAsync<RefDataNamespace.ProductCategoryCollection>(ct));

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.AccountUTypeCollection>> AccountUTypeGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, (_, ct) => _cosmos.ValueContainer<RefDataNamespace.AccountUType, Model.AccountUType>("RefData").Query().SelectQueryWithResultAsync<RefDataNamespace.AccountUTypeCollection>(ct));

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.MaturityInstructionsCollection>> MaturityInstructionsGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, (_, ct) => _cosmos.ValueContainer<RefDataNamespace.MaturityInstructions, Model.MaturityInstructions>("RefData").Query().SelectQueryWithResultAsync<RefDataNamespace.MaturityInstructionsCollection>(ct));

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.TransactionTypeCollection>> TransactionTypeGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, (_, ct) => _cosmos.ValueContainer<RefDataNamespace.TransactionType, Model.TransactionType>("RefData").Query().SelectQueryWithResultAsync<RefDataNamespace.TransactionTypeCollection>(ct));

    /// <inheritdoc/>
    public Task<Result<RefDataNamespace.TransactionStatusCollection>> TransactionStatusGetAllAsync()
        => DataInvoker.Current.InvokeAsync(this, (_, ct) => _cosmos.ValueContainer<RefDataNamespace.TransactionStatus, Model.TransactionStatus>("RefData").Query().SelectQueryWithResultAsync<RefDataNamespace.TransactionStatusCollection>(ct));

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.OpenStatus"/> to Entity Framework <see cref="Model.OpenStatus"/> mapping.
    /// </summary>
    public partial class OpenStatusToModelCosmosMapper : Mapper<RefDataNamespace.OpenStatus, Model.OpenStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenStatusToModelCosmosMapper"/> class.
        /// </summary>
        public OpenStatusToModelCosmosMapper()
        {
            Map((s, d) => d.Id = s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = s.ETag, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            OpenStatusToModelCosmosMapperCtor();
        }

        partial void OpenStatusToModelCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="Model.OpenStatus"/> to <see cref="RefDataNamespace.OpenStatus"/> mapping.
    /// </summary>
    public partial class ModelToOpenStatusCosmosMapper : Mapper<Model.OpenStatus, RefDataNamespace.OpenStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityCosmosMapper"/> class.
        /// </summary>
        public ModelToOpenStatusCosmosMapper()
        {
            Map((s, d) => d.Id = (Guid)s.Id!, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)s.ETag!, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            ModelToOpenStatusCosmosMapperCtor();
        }

        partial void ModelToOpenStatusCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.ProductCategory"/> to Entity Framework <see cref="Model.ProductCategory"/> mapping.
    /// </summary>
    public partial class ProductCategoryToModelCosmosMapper : Mapper<RefDataNamespace.ProductCategory, Model.ProductCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategoryToModelCosmosMapper"/> class.
        /// </summary>
        public ProductCategoryToModelCosmosMapper()
        {
            Map((s, d) => d.Id = s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = s.ETag, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            ProductCategoryToModelCosmosMapperCtor();
        }

        partial void ProductCategoryToModelCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="Model.ProductCategory"/> to <see cref="RefDataNamespace.ProductCategory"/> mapping.
    /// </summary>
    public partial class ModelToProductCategoryCosmosMapper : Mapper<Model.ProductCategory, RefDataNamespace.ProductCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityCosmosMapper"/> class.
        /// </summary>
        public ModelToProductCategoryCosmosMapper()
        {
            Map((s, d) => d.Id = (Guid)s.Id!, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)s.ETag!, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            ModelToProductCategoryCosmosMapperCtor();
        }

        partial void ModelToProductCategoryCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.AccountUType"/> to Entity Framework <see cref="Model.AccountUType"/> mapping.
    /// </summary>
    public partial class AccountUTypeToModelCosmosMapper : Mapper<RefDataNamespace.AccountUType, Model.AccountUType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUTypeToModelCosmosMapper"/> class.
        /// </summary>
        public AccountUTypeToModelCosmosMapper()
        {
            Map((s, d) => d.Id = s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = s.ETag, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            AccountUTypeToModelCosmosMapperCtor();
        }

        partial void AccountUTypeToModelCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="Model.AccountUType"/> to <see cref="RefDataNamespace.AccountUType"/> mapping.
    /// </summary>
    public partial class ModelToAccountUTypeCosmosMapper : Mapper<Model.AccountUType, RefDataNamespace.AccountUType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityCosmosMapper"/> class.
        /// </summary>
        public ModelToAccountUTypeCosmosMapper()
        {
            Map((s, d) => d.Id = (Guid)s.Id!, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)s.ETag!, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            ModelToAccountUTypeCosmosMapperCtor();
        }

        partial void ModelToAccountUTypeCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.MaturityInstructions"/> to Entity Framework <see cref="Model.MaturityInstructions"/> mapping.
    /// </summary>
    public partial class MaturityInstructionsToModelCosmosMapper : Mapper<RefDataNamespace.MaturityInstructions, Model.MaturityInstructions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaturityInstructionsToModelCosmosMapper"/> class.
        /// </summary>
        public MaturityInstructionsToModelCosmosMapper()
        {
            Map((s, d) => d.Id = s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = s.ETag, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            MaturityInstructionsToModelCosmosMapperCtor();
        }

        partial void MaturityInstructionsToModelCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="Model.MaturityInstructions"/> to <see cref="RefDataNamespace.MaturityInstructions"/> mapping.
    /// </summary>
    public partial class ModelToMaturityInstructionsCosmosMapper : Mapper<Model.MaturityInstructions, RefDataNamespace.MaturityInstructions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityCosmosMapper"/> class.
        /// </summary>
        public ModelToMaturityInstructionsCosmosMapper()
        {
            Map((s, d) => d.Id = (Guid)s.Id!, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)s.ETag!, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            ModelToMaturityInstructionsCosmosMapperCtor();
        }

        partial void ModelToMaturityInstructionsCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.TransactionType"/> to Entity Framework <see cref="Model.TransactionType"/> mapping.
    /// </summary>
    public partial class TransactionTypeToModelCosmosMapper : Mapper<RefDataNamespace.TransactionType, Model.TransactionType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTypeToModelCosmosMapper"/> class.
        /// </summary>
        public TransactionTypeToModelCosmosMapper()
        {
            Map((s, d) => d.Id = s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = s.ETag, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            TransactionTypeToModelCosmosMapperCtor();
        }

        partial void TransactionTypeToModelCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="Model.TransactionType"/> to <see cref="RefDataNamespace.TransactionType"/> mapping.
    /// </summary>
    public partial class ModelToTransactionTypeCosmosMapper : Mapper<Model.TransactionType, RefDataNamespace.TransactionType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityCosmosMapper"/> class.
        /// </summary>
        public ModelToTransactionTypeCosmosMapper()
        {
            Map((s, d) => d.Id = (Guid)s.Id!, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)s.ETag!, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            ModelToTransactionTypeCosmosMapperCtor();
        }

        partial void ModelToTransactionTypeCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the <see cref="RefDataNamespace.TransactionStatus"/> to Entity Framework <see cref="Model.TransactionStatus"/> mapping.
    /// </summary>
    public partial class TransactionStatusToModelCosmosMapper : Mapper<RefDataNamespace.TransactionStatus, Model.TransactionStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatusToModelCosmosMapper"/> class.
        /// </summary>
        public TransactionStatusToModelCosmosMapper()
        {
            Map((s, d) => d.Id = s.Id, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = s.Code, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = s.Text, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = s.IsActive, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = s.SortOrder, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = s.ETag, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            TransactionStatusToModelCosmosMapperCtor();
        }

        partial void TransactionStatusToModelCosmosMapperCtor(); // Enables the constructor to be extended.
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="Model.TransactionStatus"/> to <see cref="RefDataNamespace.TransactionStatus"/> mapping.
    /// </summary>
    public partial class ModelToTransactionStatusCosmosMapper : Mapper<Model.TransactionStatus, RefDataNamespace.TransactionStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityCosmosMapper"/> class.
        /// </summary>
        public ModelToTransactionStatusCosmosMapper()
        {
            Map((s, d) => d.Id = (Guid)s.Id!, OperationTypes.Any, s => s.Id == default, d => d.Id = default);
            Map((s, d) => d.Code = (string?)s.Code!, OperationTypes.Any, s => s.Code == default, d => d.Code = default);
            Map((s, d) => d.Text = (string?)s.Text!, OperationTypes.Any, s => s.Text == default, d => d.Text = default);
            Map((s, d) => d.IsActive = (bool)s.IsActive!, OperationTypes.Any, s => s.IsActive == default, d => d.IsActive = default);
            Map((s, d) => d.SortOrder = (int)s.SortOrder!, OperationTypes.Any, s => s.SortOrder == default, d => d.SortOrder = default);
            Map((s, d) => d.ETag = (string?)s.ETag!, OperationTypes.Any, s => s.ETag == default, d => d.ETag = default);
            ModelToTransactionStatusCosmosMapperCtor();
        }

        partial void ModelToTransactionStatusCosmosMapperCtor(); // Enables the constructor to be extended.
    }
}