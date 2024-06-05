using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class RoleDto
	{
		public Guid RoleID { get; set; }
		public string RoleCode { get; set; }
		public string RoleName { get; set; }
		public DateTime DateCreated { get; set; }
	}
}
