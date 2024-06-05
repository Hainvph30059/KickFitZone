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
	public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{
			builder.HasKey(c => c.CustomerID);
			builder.Property(c => c.FullName).IsRequired().HasMaxLength(100);
			builder.Property(c => c.UserName).IsRequired().HasMaxLength(50);
			builder.Property(c => c.Password).IsRequired().HasMaxLength(100);
			builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
			builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(20);
			builder.Property(c => c.Sex).IsRequired().HasMaxLength(10);
			builder.Property(c => c.DateCreated).IsRequired();

			builder.HasMany(c => c.Bills)
				   .WithOne(b => b.Customer)
				   .HasForeignKey(b => b.CustomerID);

			builder.HasMany(c => c.Addresses)
				   .WithOne(a => a.Customer)
				   .HasForeignKey(a => a.CustomerID);

			builder.HasOne(c => c.Carts)
				   .WithOne(cart => cart.Customer)
				   .HasForeignKey<Cart>(cart => cart.CustomerID);
			//builder.HasMany(c => c.Carts)
			//	   .WithOne(ca => ca.Customer)
			//	   .HasForeignKey(ca => ca.CustomerID);
		}
	}
}
