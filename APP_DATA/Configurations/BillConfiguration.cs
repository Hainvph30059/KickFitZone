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
	public class BillConfiguration : IEntityTypeConfiguration<Bill>
	{
		public void Configure(EntityTypeBuilder<Bill> builder)
		{
			builder.HasKey(b => b.ID);
			builder.Property(b => b.BillCode).IsRequired().HasMaxLength(50);
			builder.Property(b => b.DateCreated).IsRequired();
			builder.Property(b => b.TotalPrice).IsRequired();
			builder.Property(b => b.ShippingCosts).IsRequired();
			builder.Property(b => b.Status).IsRequired().HasMaxLength(20);
			builder.Property(b => b.TotalPriceAfterDiscount).IsRequired();
			builder.Property(b => b.IsPaid).IsRequired();

			builder.HasOne(b => b.Voucher)
				   .WithMany(v => v.Bills)
				   .HasForeignKey(b => b.VoucherID)
				   .OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(b => b.Employee)
				   .WithMany(e => e.Bills)
				   .HasForeignKey(b => b.EmployeeID);

			builder.HasOne(b => b.PurchaseMethod)
				   .WithMany(p => p.Bills)
				   .HasForeignKey(b => b.PurchaseMethodID)
				   .OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(b => b.Customer)
				   .WithMany(c => c.Bills)
				   .HasForeignKey(b => b.CustomerID)
				   .OnDelete(DeleteBehavior.NoAction);

			builder.HasMany(b => b.BillDetails)
				   .WithOne(bd => bd.Bill)
				   .HasForeignKey(bd => bd.BillID)
				   .OnDelete(DeleteBehavior.NoAction);

			builder.HasMany(b => b.BillStatusHistories)
				   .WithOne(bsh => bsh.Bill)
				   .HasForeignKey(bsh => bsh.BillID)
				   .OnDelete(DeleteBehavior.NoAction);
		}
	}
}
