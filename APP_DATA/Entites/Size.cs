using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Size
	{
		public Guid SizeID { get; set; }
		public string SizeCode { get; set; }
		public string Name { get; set; }
		public string Status { get; set; }
		public DateTime DateCreated { get; set; }

		public ICollection<ShoesDetails_Size> ShoesDetails_Sizes { get; set; }
	}
}
