using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class PurchaseMethod
	{
		public Guid PurchaseMethodID { get; set; }
		public string Name { get; set; }
		public string Status { get; set; }
		public DateTime DateCreated { get; set; }

		public ICollection<Bill> Bills { get; set; }
	}
}
