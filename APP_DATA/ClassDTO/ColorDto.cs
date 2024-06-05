using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class ColorDto
	{
		public Guid ColorID { get; set; }
		public string ColorCode { get; set; }
		public string Name { get; set; }
		public string Status { get; set; }
		public DateTime DateCreated { get; set; }
	}
}
