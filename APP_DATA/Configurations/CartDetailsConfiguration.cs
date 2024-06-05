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
	public class CartDetailsConfiguration : IEntityTypeConfiguration<CartDetails>
	{
		public void Configure(EntityTypeBuilder<CartDetails> builder)
		{
			builder.HasKey(cd => cd.ID);

			builder.HasOne(cd => cd.Cart)
				   .WithMany(ca => ca.CartDetails)
				   .HasForeignKey(cd => cd.CartID);
		}
	}
}
