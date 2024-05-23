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
	public class MaterialConfiguration : IEntityTypeConfiguration<Material>
	{
		public void Configure(EntityTypeBuilder<Material> builder)
		{
			builder.HasKey(m => m.MaterialID);
			builder.Property(m => m.MaterialCode).IsRequired().HasMaxLength(20);
			builder.Property(m => m.Name).IsRequired().HasMaxLength(50);
			builder.Property(m => m.Status).IsRequired().HasMaxLength(20);
			builder.Property(m => m.DateCreated).IsRequired();
		}
	}
}
