using APP_DATA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.EntityConfiguration
{
	public class AddressConfiguration : IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{
			builder.HasKey(a => a.AddressID);
			builder.Property(a => a.Street).IsRequired().HasMaxLength(100);
			builder.Property(a => a.Commune).IsRequired().HasMaxLength(50);
			builder.Property(a => a.District).IsRequired().HasMaxLength(50);
			builder.Property(a => a.Province).IsRequired().HasMaxLength(50);
			builder.Property(a => a.Status).IsRequired().HasMaxLength(20);
			builder.Property(a => a.DateCreated).IsRequired();
			builder.Property(a => a.ShippingCost).IsRequired();
			builder.Property(a => a.DistrictCode).IsRequired().HasMaxLength(10);
			builder.Property(a => a.WardCode).IsRequired().HasMaxLength(10);

			builder.HasOne(a => a.Customer)
				   .WithMany(c => c.Addresses)
				   .HasForeignKey(a => a.CustomerID);
		}
	}
}
