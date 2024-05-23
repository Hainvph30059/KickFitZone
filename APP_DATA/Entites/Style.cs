using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Style
	{
		public Guid StyleID { get; set; }
		public string StyleCode { get; set; }
		public string Name { get; set; }
		public string Status { get; set; }
		public DateTime DateCreated { get; set; }

		public ICollection<ShoesDetails> ShoesDetails { get; set; }
	}
}
