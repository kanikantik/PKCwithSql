// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SupplierMap.cs" company="EPAM Systems">
//   Copyright 2012
// </copyright>
// <summary>
//   The supplier map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PKCDashboard.Entities.Mappings
{
    using System.Data.Entity.ModelConfiguration;
    using System.Diagnostics.CodeAnalysis;
    using Entities;
    /// <summary>
    /// The supplier map.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplierMap" /> class.
        /// </summary>
        public SupplierMap()
        {
            // Primary Key
            this.HasKey(t => t.SupplierId);

            // Properties
            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ContactName)
                .HasMaxLength(30);

            this.Property(t => t.ContactTitle)
                .HasMaxLength(30);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.Region)
                .HasMaxLength(15);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            this.Property(t => t.Phone)
                .HasMaxLength(24);

            this.Property(t => t.Fax)
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("Suppliers");
            this.Property(t => t.SupplierId).HasColumnName("SupplierID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.ContactTitle).HasColumnName("ContactTitle");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Homepage).HasColumnName("HomePage");
        }
    }
}
