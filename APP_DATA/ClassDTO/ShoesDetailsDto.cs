using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class ShoesDetailsDto
	{
		public Guid ShoesDetailsID { get; set; }
		public string ShoesDetailsCode { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }
		public Guid ColorID { get; set; }
		public Guid ProductID { get; set; }
		public Guid StyleID { get; set; }
		public Guid SexID { get; set; }
		public Guid MaterialID { get; set; }
		public Guid ImageID { get; set; }
		public Guid SizeID { get; set; }
	}
}
