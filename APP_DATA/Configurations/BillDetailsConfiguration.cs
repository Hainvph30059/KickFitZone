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
	public class BillDetailsConfiguration : IEntityTypeConfiguration<BillDetails>
	{
		public void Configure(EntityTypeBuilder<BillDetails> builder)
		{
			builder.HasKey(bd => bd.ID);

			builder.HasOne(bd => bd.Bill)
				   .WithMany(b => b.BillDetails)
				   .HasForeignKey(bd => bd.BillID);
		}
	}
}
