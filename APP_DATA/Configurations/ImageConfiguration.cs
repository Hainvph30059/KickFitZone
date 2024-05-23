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
	public class ImageConfiguration : IEntityTypeConfiguration<Image>
	{
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.HasKey(i => i.ImageID);
			builder.Property(i => i.ImageCode).IsRequired().HasMaxLength(20);
			builder.Property(i => i.Name).IsRequired().HasMaxLength(100);
			builder.Property(i => i.Status).IsRequired().HasMaxLength(20);
			builder.Property(i => i.ImageUrl1).HasMaxLength(255);
			builder.Property(i => i.ImageUrl2).HasMaxLength(255);
			builder.Property(i => i.ImageUrl3).HasMaxLength(255);
			builder.Property(i => i.ImageUrl4).HasMaxLength(255);
			builder.Property(i => i.DateCreated).IsRequired();
		}
	}
}
