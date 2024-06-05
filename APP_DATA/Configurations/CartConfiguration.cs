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
	public class CartConfiguration : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			builder.HasKey(c => c.CartID);
			//builder.HasOne(c => c.Customer)
			//	   .WithOne(cu => cu.Carts)
			//	   .HasForeignKey(c => c.CustomerID);
			builder.HasMany(c => c.CartDetails)
				   .WithOne(cartDetail => cartDetail.Cart)
				   .HasForeignKey(cartDetails => cartDetails.CartID);
			
		}
	}
}
