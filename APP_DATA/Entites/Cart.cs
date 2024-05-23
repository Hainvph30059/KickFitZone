using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Cart
	{
		public Guid CartID { get; set; }
		public Guid CustomerID { get; set; }
		public string Description { get; set; }

		public Customer Customer { get; set; }
		public ICollection<CartDetails> CartDetails { get; set; }
	}
}
