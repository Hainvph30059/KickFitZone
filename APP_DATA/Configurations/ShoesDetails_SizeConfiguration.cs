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
	public class ShoesDetails_SizeConfiguration : IEntityTypeConfiguration<ShoesDetails_Size>
	{
		public void Configure(EntityTypeBuilder<ShoesDetails_Size> builder)
		{
			builder.HasKey(sd => sd.ID);

			builder.HasOne(sd => sd.ShoesDetails)
				   .WithMany(s => s.ShoesDetails_Sizes)
				   .HasForeignKey(sd => sd.ShoesDetailsID)
				   .OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(sd => sd.Size)
				   .WithMany(s => s.ShoesDetails_Sizes)
				   .HasForeignKey(sd => sd.SizeID);
		}
	}
}
