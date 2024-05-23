using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Material
	{
		public Guid MaterialID { get; set; }
		public string MaterialCode { get; set; }
		public string Name { get; set; }
		public string Status { get; set; }
		public DateTime DateCreated { get; set; }

		public ICollection<ShoesDetails> ShoesDetails { get; set; }
	}
}
