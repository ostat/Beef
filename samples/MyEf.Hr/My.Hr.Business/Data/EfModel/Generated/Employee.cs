/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace My.Hr.Business.Data.EfModel
{
    /// <summary>
    /// Represents the Entity Framework (EF) model for database object '[Hr].[Employee]'.
    /// </summary>
    public partial class Employee
    {
        /// <summary>
        /// Gets or sets the 'EmployeeId' column value.
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the 'Email' column value.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the 'FirstName' column value.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the 'LastName' column value.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the 'GenderCode' column value.
        /// </summary>
        public string? GenderCode { get; set; }

        /// <summary>
        /// Gets or sets the 'Birthday' column value.
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or sets the 'StartDate' column value.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the 'TerminationDate' column value.
        /// </summary>
        public DateTime? TerminationDate { get; set; }

        /// <summary>
        /// Gets or sets the 'TerminationReasonCode' column value.
        /// </summary>
        public string? TerminationReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the 'PhoneNo' column value.
        /// </summary>
        public string? PhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the 'AddressJson' column value.
        /// </summary>
        public string? AddressJson { get; set; }

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
        /// Gets or sets the <i>OneToMany</i> relationship to <see cref="EmergencyContact"/>.
        /// </summary>
        public List<EmergencyContact> EmergencyContacts { get; set; }

        /// <summary>
        /// Gets or sets the <i>OneToMany</i> relationship to <see cref="PerformanceReview"/>.
        /// </summary>
        public List<PerformanceReview> PerformanceReviews { get; set; }

        /// <summary>
        /// Adds the table/model configuration to the <see cref="ModelBuilder"/>.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ModelBuilder"/>.</param>
        public static void AddToModel(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee", "Hr");
                entity.HasKey(nameof(EmployeeId));
                entity.Property(p => p.EmployeeId).HasColumnName("EmployeeId").HasColumnType("UNIQUEIDENTIFIER");
                entity.Property(p => p.Email).HasColumnName("Email").HasColumnType("NVARCHAR(250)");
                entity.Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("NVARCHAR(100)");
                entity.Property(p => p.LastName).HasColumnName("LastName").HasColumnType("NVARCHAR(100)");
                entity.Property(p => p.GenderCode).HasColumnName("GenderCode").HasColumnType("NVARCHAR(50)");
                entity.Property(p => p.Birthday).HasColumnName("Birthday").HasColumnType("DATE");
                entity.Property(p => p.StartDate).HasColumnName("StartDate").HasColumnType("DATE");
                entity.Property(p => p.TerminationDate).HasColumnName("TerminationDate").HasColumnType("DATE");
                entity.Property(p => p.TerminationReasonCode).HasColumnName("TerminationReasonCode").HasColumnType("NVARCHAR(50)");
                entity.Property(p => p.PhoneNo).HasColumnName("PhoneNo").HasColumnType("NVARCHAR(50)");
                entity.Property(p => p.AddressJson).HasColumnName("AddressJson").HasColumnType("NVARCHAR(500)");
                entity.Property(p => p.RowVersion).HasColumnName("RowVersion").HasColumnType("TIMESTAMP").IsRowVersion();
                entity.Property(p => p.CreatedBy).HasColumnName("CreatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnUpdate();
                entity.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnType("DATETIME2").ValueGeneratedOnUpdate();
                entity.Property(p => p.UpdatedBy).HasColumnName("UpdatedBy").HasColumnType("NVARCHAR(250)").ValueGeneratedOnAdd();
                entity.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").HasColumnType("DATETIME2").ValueGeneratedOnAdd();

                // Relationships...
                entity.HasMany(r => r.EmergencyContacts).WithOne().HasForeignKey(fk => fk.EmployeeId).OnDelete(DeleteBehavior.Cascade);
                entity.Navigation(r => r.EmergencyContacts).AutoInclude(true);
                entity.HasMany(r => r.PerformanceReviews).WithOne().HasForeignKey(fk => fk.EmployeeId).OnDelete(DeleteBehavior.Cascade);
                entity.Navigation(r => r.PerformanceReviews).AutoInclude(false);
                AddToModel(entity);
            });
        }
        
        /// <summary>
        /// Enables further configuration of the underlying <see cref="EntityTypeBuilder"/> when configuring the <see cref="ModelBuilder"/>.
        /// </summary>
        static partial void AddToModel(EntityTypeBuilder<Employee> entity);
    }
}

#pragma warning restore
#nullable restore