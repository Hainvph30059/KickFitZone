using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Sex
	{
		public Guid SexID { get; set; }
		public string SexName { get; set; }

		public ICollection<ShoesDetails> ShoesDetails { get; set; }
	}
}
