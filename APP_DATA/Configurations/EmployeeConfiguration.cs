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
	public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.HasKey(e => e.EmployeeID);
			builder.Property(e => e.FullName).IsRequired().HasMaxLength(100);
			builder.Property(e => e.UserName).IsRequired().HasMaxLength(50);
			builder.Property(e => e.Password).IsRequired().HasMaxLength(100);
			builder.Property(e => e.Sex).IsRequired().HasMaxLength(10);
			builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(20);
			builder.Property(e => e.Email).IsRequired().HasMaxLength(100);
			builder.Property(e => e.Status).IsRequired().HasMaxLength(20);
			builder.Property(e => e.DateCreated).IsRequired();
			builder.Property(e => e.IdentificationCode).HasMaxLength(50);
			builder.Property(e => e.Image).HasMaxLength(255);

			builder.HasOne(e => e.Role)
				   .WithMany(r => r.Employees)
				   .HasForeignKey(e => e.RoleID);
		}
	}
}
