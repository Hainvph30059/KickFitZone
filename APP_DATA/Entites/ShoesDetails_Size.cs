using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class ShoesDetails_Size
	{
		public Guid ID { get; set; }
		public Guid ShoesDetailsID { get; set; }
		public Guid SizeID { get; set; }
		public int Quantity { get; set; }

		public ShoesDetails ShoesDetails { get; set; }
		public Size Size { get; set; }
		public ICollection<CartDetails> CartDetails { get; set; }
	}
}
