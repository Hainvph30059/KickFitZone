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
	public class PurchaseMethodConfiguration : IEntityTypeConfiguration<PurchaseMethod>
	{
		public void Configure(EntityTypeBuilder<PurchaseMethod> builder)
		{
			builder.HasKey(p => p.PurchaseMethodID);
			builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
			builder.Property(p => p.Status).IsRequired().HasMaxLength(20);
			builder.Property(p => p.DateCreated).IsRequired();
		}
	}
}
