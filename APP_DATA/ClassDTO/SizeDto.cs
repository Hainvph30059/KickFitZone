using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class SizeDto
	{
		public Guid SizeID { get; set; }
		public string SizeCode { get; set; }
		public string Name { get; set; }
		public string Status { get; set; }
		public DateTime DateCreated { get; set; }
	}
}
