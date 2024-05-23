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
	public class StyleConfiguration : IEntityTypeConfiguration<Style>
	{
		public void Configure(EntityTypeBuilder<Style> builder)
		{
			builder.HasKey(s => s.StyleID);
			builder.Property(s => s.StyleCode).IsRequired().HasMaxLength(10);
			builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
			builder.Property(s => s.Status).IsRequired().HasMaxLength(20);
			builder.Property(s => s.DateCreated).IsRequired();
		}
	}
}
