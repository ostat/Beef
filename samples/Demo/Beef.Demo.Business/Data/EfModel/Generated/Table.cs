/*
 * This file is automatically generated; any changes will be lost. 
 */

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Beef.Demo.Business.Data.EfModel;

/// <summary>
/// Represents the Entity Framework (EF) model for SqlServer database object [Test].[Table].
/// </summary>
public partial class Table : ILogicallyDeleted, ITenantId
{
    /// <summary>
    /// Gets or sets the 'TableId' column value.
    /// </summary>
    public Guid TableId { get; set; }

    /// <summary>
    /// Gets or sets the 'Name' column value.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the 'Count' column value.
    /// </summary>
    public int? Count { get; set; }

    /// <summary>
    /// Gets or sets the 'Amount' column value.
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Gets or sets the 'Other' column value.
    /// </summary>
    public string? Other { get; set; }

    /// <summary>
    /// Gets or sets the 'GenderCode' column value.
    /// </summary>
    public string? GenderCode { get; set; }

    /// <summary>
    /// Gets or sets the 'OrgUnitId' column value.
    /// </summary>
    public Guid? OrgUnitId { get; set; }

    /// <summary>
    /// Gets or sets the 'RowVersion' column value.
    /// </summary>
    public byte[]? RowVersion { get; set; }

    /// <summary>
    /// Gets or sets the 'CreatedBy' column value.
    /// </summary>
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the 'CreatedDate' column value.
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the 'UpdatedBy' column value.
    /// </summary>
    public string? UpdatedBy { get; set; }

    /// <summary>
    /// Gets or sets the 'UpdatedDate' column value.
    /// </summary>
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// Gets or sets the 'IsDeleted' column value.
    /// </summary>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets the 'TenantId' column value.
    /// </summary>
    public string? TenantId { get; set; }

    /// <summary>
    /// Adds the table/model configuration to the <see cref="ModelBuilder"/>.
    /// </summary>
    /// <param name="modelBuilder">The <see cref="ModelBuilder"/>.</param>
    public static void AddToModel(ModelBuilder modelBuilder)
    {
        modelBuilder.ThrowIfNull().Entity<Table>(entity =>
        {
            entity.ToTable("Table", "Test");
            entity.HasKey(nameof(TableId));
            entity.Property(p => p.TableId).HasColumnName("TableId").HasColumnType("UNIQUEIDENTIFIER");
            entity.Property(p => p.Name).HasColumnName("Name").HasColumnType("NVARCHAR(50)");
            entity.Property(p => p.Count).HasColumnName("Count").HasColumnType("INT");
            entity.Property(p => p.Amount).HasColumnName("Amount").HasColumnType("DECIMAL(16, 9)");
            entity.Property(p => p.Other).HasColumnName("Other").HasColumnType("NVARCHAR(50)");
            entity.Property(p => p.GenderCode).HasColumnName("GenderCode").HasColumnType("NVARCHAR(50)");
            entity.Property(p => p.OrgUnitId).HasColumnName("OrgUnitId").HasColumnType("UNIQUEIDENTIFIER");
            entity.Property(p => p.RowVersion).HasColumnName("RowVersion").HasColumnType("TIMESTAMP").IsRowVersion();
            entity.Property(p => p.CreatedBy).HasColumnName("CreatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnUpdate();
            entity.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnType("DATETIME2").ValueGeneratedOnUpdate();
            entity.Property(p => p.UpdatedBy).HasColumnName("UpdatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnAdd();
            entity.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").HasColumnType("DATETIME2").ValueGeneratedOnAdd();
            entity.Property(p => p.IsDeleted).HasColumnName("IsDeleted").HasColumnType("BIT");
            entity.HasQueryFilter(v => v.IsDeleted != true);
            entity.Property(p => p.TenantId).HasColumnName("TenantId").HasColumnType("NVARCHAR(50)");
            entity.HasQueryFilter(v => v.TenantId == CoreEx.ExecutionContext.Current.TenantId);
            AddToModel(entity);
        });
    }
        
    /// <summary>
    /// Enables further configuration of the underlying <see cref="EntityTypeBuilder"/> when configuring the <see cref="ModelBuilder"/>.
    /// </summary>
    static partial void AddToModel(EntityTypeBuilder<Table> entity);
}