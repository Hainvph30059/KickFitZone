using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class CartDetails
	{
		public Guid ID { get; set; }
		public int Quantity { get; set; }
		public Guid CartID { get; set; }
		public Guid ShoeDetailsID { get; set; }
		

		public Cart Cart { get; set; }
		public ShoesDetails ShoesDetails { get; set; }
		
	}
}
