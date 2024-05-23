using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class EmployeeDto
	{
		public Guid EmployeeID { get; set; }
		public string FullName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Sex { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Status { get; set; }
		public DateTime DateCreated { get; set; }
		public string IdentificationCode { get; set; }
		public string Image { get; set; }
		public Guid RoleID { get; set; }
	}
}
