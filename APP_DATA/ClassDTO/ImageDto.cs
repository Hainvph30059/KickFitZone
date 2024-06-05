using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ClassDTO
{
	public class ImageDto
	{
		public Guid ImageID { get; set; }
		public string ImageCode { get; set; }
		public string Name { get; set; }
		public string Status { get; set; }
		public string ImageUrl1 { get; set; }
		public string ImageUrl2 { get; set; }
		public string ImageUrl3 { get; set; }
		public string ImageUrl4 { get; set; }
		public DateTime DateCreated { get; set; }
	}
}
