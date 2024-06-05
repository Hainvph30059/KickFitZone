namespace APP_DATA.Entity
{
	public class ShoesDetails
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
		
		
		public Color Color { get; set; }
		public Product Product { get; set; }
		public Style Style { get; set; }
		public Sex Sex { get; set; }
		public Material Material { get; set; }
		public Image Image { get; set; }
		public Size Size { get; set; }

		public ICollection<CartDetails> CartDetails { get; set; }
	}
}
