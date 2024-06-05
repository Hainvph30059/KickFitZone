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
	public class SizeConfiguration : IEntityTypeConfiguration<Size>
	{
		public void Configure(EntityTypeBuilder<Size> builder)
		{
			builder.HasKey(s => s.SizeID);
			builder.Property(s => s.SizeCode).IsRequired().HasMaxLength(10);
			builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
			builder.Property(s => s.Status).IsRequired().HasMaxLength(20);
			builder.Property(s => s.DateCreated).IsRequired();
			
		}
	}
}
