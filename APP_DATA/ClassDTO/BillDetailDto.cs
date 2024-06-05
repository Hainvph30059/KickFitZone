using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class BillDetailDto
	{
		public Guid ID { get; set; }
		public Guid BillID { get; set; }
		public Guid ShoesDetails_SizeID { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public string Status { get; set; }
	}
}
