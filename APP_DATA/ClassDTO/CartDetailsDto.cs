using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class CartDetailsDto
	{
		public Guid ID { get; set; }
		public int Quantity { get; set; }
		public Guid CartID { get; set; }
		public Guid ShoeDetailsID { get; set; }
	}
}
