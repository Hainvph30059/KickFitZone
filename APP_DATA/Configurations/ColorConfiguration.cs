using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_DATA.Entity;

namespace APP_DATA.EntityConfiguration
{
	public class ColorConfiguration : IEntityTypeConfiguration<Color>
	{
		public void Configure(EntityTypeBuilder<Color> builder)
		{
			builder.HasKey(c => c.ColorID);
			builder.Property(c => c.ColorCode).IsRequired().HasMaxLength(10);
			builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
			builder.Property(c => c.Status).IsRequired().HasMaxLength(20);
			builder.Property(c => c.DateCreated).IsRequired();
		}
	}
}
