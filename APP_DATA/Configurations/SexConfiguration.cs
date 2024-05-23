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
	public class SexConfiguration : IEntityTypeConfiguration<Sex>
	{
		public void Configure(EntityTypeBuilder<Sex> builder)
		{
			builder.HasKey(s => s.SexID);
			builder.Property(s => s.SexName).IsRequired().HasMaxLength(10);
		}
	}
}
