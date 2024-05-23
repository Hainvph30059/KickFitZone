using APP_DATA.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.EntityConfiguration
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(p => p.ProductID);
			builder.Property(p => p.ProductCode).IsRequired().HasMaxLength(20);
			builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
			builder.Property(p => p.Status).IsRequired().HasMaxLength(20);
			builder.Property(p => p.DateCreated).IsRequired();
		}
	}
}
