using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class AddressDto
	{
		public Guid AddressID { get; set; }
		public string Street { get; set; }
		public string Commune { get; set; }
		public string District { get; set; }
		public string Province { get; set; }
		public string Status { get; set; }
		public DateTime DateCreated { get; set; }
		public bool IsDefaultAddress { get; set; }
		public decimal ShippingCost { get; set; }
		public string DistrictCode { get; set; }
		public string WardCode { get; set; }
		public Guid CustomerID { get; set; }
	}
}
