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
	public class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.HasKey(r => r.RoleID);
			builder.Property(r => r.RoleCode).IsRequired().HasMaxLength(20);
			builder.Property(r => r.RoleName).IsRequired().HasMaxLength(100);
			builder.Property(r => r.DateCreated).IsRequired();
		}
	}
}
