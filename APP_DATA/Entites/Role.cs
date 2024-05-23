using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Role
	{
		public Guid RoleID { get; set; }
		public string RoleCode { get; set; }
		public string RoleName { get; set; }
		public DateTime DateCreated { get; set; }

		public ICollection<Employee> Employees { get; set; }
	}
}
