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
	public class BillStatusHistoryConfiguration : IEntityTypeConfiguration<BillStatusHistory>
	{
		public void Configure(EntityTypeBuilder<BillStatusHistory> builder)
		{
			builder.HasKey(bsh => bsh.BillStatusHistoryID);

			builder.HasOne(bsh => bsh.Bill)
				   .WithMany(b => b.BillStatusHistories)
				   .HasForeignKey(bsh => bsh.BillID);
		}
	}
}
