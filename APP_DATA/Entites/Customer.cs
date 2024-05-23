using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Customer
	{
		public Guid CustomerID { get; set; }
		public string FullName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string ResetPassword { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Sex { get; set; }
		public DateTime DateCreated { get; set; }

		public ICollection<Bill> Bills { get; set; }
		public ICollection<Address> Addresses { get; set; }
		public Cart Carts { get; set; }
		
	}
}
