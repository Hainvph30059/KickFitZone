using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Voucher
	{
		public Guid VoucherID { get; set; }
		public string VoucherCode { get; set; }
		public decimal VoucherValue { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime ExpirationDate { get; set; }
		public decimal RemainingUsage { get; set; }
		public decimal MaxUsage { get; set; }
		public bool Status { get; set; }
		public int Total { get; set; }

		public ICollection<Bill> Bills { get; set; }
	}
}
