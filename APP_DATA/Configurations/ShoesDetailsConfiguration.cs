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
	public class ShoesDetailsConfiguration : IEntityTypeConfiguration<ShoesDetails>
	{
		public void Configure(EntityTypeBuilder<ShoesDetails> builder)
		{
			builder.HasKey(sd => sd.ShoesDetailsID);
			builder.Property(sd => sd.ShoesDetailsCode).IsRequired().HasMaxLength(50);
			builder.Property(sd => sd.Price).IsRequired();
			builder.Property(sd => sd.Description).HasMaxLength(500);
			builder.Property(sd => sd.Status).IsRequired().HasMaxLength(20);

			builder.HasOne(s => s.Size)
				   .WithMany(sd => sd.ShoesDetails)
				   .HasForeignKey(sd => sd.SizeID);

			builder.HasOne(sd => sd.Color)
				   .WithMany(c => c.ShoesDetails)
				   .HasForeignKey(sd => sd.ColorID);

			builder.HasOne(sd => sd.Product)
				   .WithMany(p => p.ShoesDetails)
				   .HasForeignKey(sd => sd.ProductID);

			builder.HasOne(sd => sd.Style)
				   .WithMany(st => st.ShoesDetails)
				   .HasForeignKey(sd => sd.StyleID);

			builder.HasOne(sd => sd.Sex)
				   .WithMany(s => s.ShoesDetails)
				   .HasForeignKey(sd => sd.SexID);

			builder.HasOne(sd => sd.Material)
				   .WithMany(m => m.ShoesDetails)
				   .HasForeignKey(sd => sd.MaterialID);

			builder.HasOne(sd => sd.Image)
				   .WithMany(i => i.ShoesDetails)
				   .HasForeignKey(sd => sd.ImageID);

			builder.HasMany(shoeDetail => shoeDetail.CartDetails)
				   .WithOne(cartDetails => cartDetails.ShoesDetails)
				   .HasForeignKey(cartDetails => cartDetails.ShoeDetailsID);
		}
	}
}
