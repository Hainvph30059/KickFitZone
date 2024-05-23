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
	public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
	{
		public void Configure(EntityTypeBuilder<Voucher> builder)
		{
			builder.HasKey(v => v.VoucherID);
			builder.Property(v => v.VoucherCode).IsRequired().HasMaxLength(50);
			builder.Property(v => v.VoucherValue).IsRequired();
			builder.Property(v => v.ExpirationDate).IsRequired();
			builder.Property(v => v.MaxUsage).IsRequired();
			builder.Property(v => v.RemainingUsage).IsRequired();
			builder.Property(v => v.Status).IsRequired().HasMaxLength(20);
			builder.Property(v => v.DateCreated).IsRequired();
			builder.Property(v => v.Total).IsRequired();

			builder.HasMany(v => v.Bills)
				   .WithOne(b => b.Voucher)
				   .HasForeignKey(b => b.VoucherID);
		}
	}
}
