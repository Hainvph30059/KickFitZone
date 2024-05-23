using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class ShoesDetails
	{
		public Guid ShoesDetailsID { get; set; }
		public string ShoesDetailsCode { get; set; }
		public decimal Price { get; set; }
		public decimal ImportPrice { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }
		public Guid ColorID { get; set; }
		public Guid ProductID { get; set; }
		public Guid StyleID { get; set; }
		public Guid SexID { get; set; }
		public Guid MaterialID { get; set; }
		public Guid ImageID { get; set; }
		public Guid ShoesDetails_SizeID { get; set; }

		public Color Color { get; set; }
		public Product Product { get; set; }
		public Style Style { get; set; }
		public Sex Sex { get; set; }
		public Material Material { get; set; }
		public Image Image { get; set; }
		public ICollection<ShoesDetails_Size> ShoesDetails_Sizes { get; set; }
	}
}
