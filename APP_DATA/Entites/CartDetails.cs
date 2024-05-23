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
		public Guid ShoesDetails_SizeID { get; set; }
		public int Quantity { get; set; }

		public Guid CartID { get; set; }
		public ShoesDetails_Size ShoesDetails_Size { get; set; }
		public Cart Cart { get; set; }
	}
}
