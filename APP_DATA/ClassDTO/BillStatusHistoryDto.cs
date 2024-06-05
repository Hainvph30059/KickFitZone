using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class BillStatusHistoryDto
	{
		public Guid BillStatusHistoryID { get; set; }
		public string Status { get; set; }
		public DateTime ChangeDate { get; set; }
		public string Note { get; set; }
		public Guid BillID { get; set; }
	}
}
