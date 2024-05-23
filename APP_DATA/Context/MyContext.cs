using APP_DATA.Entity;
using APP_DATA.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Context
{
	public class MyContext : DbContext
	{
		public MyContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Voucher> Vouchers { get; set; }
		public DbSet<Bill> Bills { get; set; }
		public DbSet<PurchaseMethod> PurchaseMethods { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartDetails> CartDetails { get; set; }
		public DbSet<ShoesDetails> ShoesDetails { get; set; }
		public DbSet<ShoesDetails_Size> ShoesDetails_Sizes { get; set; }
		public DbSet<Size> Sizes { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<Style> Styles { get; set; }
		public DbSet<Sex> Sexes { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Material> Materials { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<BillDetails> BillDetails { get; set; }
		public DbSet<BillStatusHistory> BillStatusHistories { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Role> Roles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new VoucherConfiguration());
			modelBuilder.ApplyConfiguration(new BillConfiguration());
			modelBuilder.ApplyConfiguration(new PurchaseMethodConfiguration());
			modelBuilder.ApplyConfiguration(new CustomerConfiguration());
			modelBuilder.ApplyConfiguration(new AddressConfiguration());
			modelBuilder.ApplyConfiguration(new CartConfiguration());
			modelBuilder.ApplyConfiguration(new CartDetailsConfiguration());
			modelBuilder.ApplyConfiguration(new ShoesDetailsConfiguration());
			modelBuilder.ApplyConfiguration(new ShoesDetails_SizeConfiguration());
			modelBuilder.ApplyConfiguration(new SizeConfiguration());
			modelBuilder.ApplyConfiguration(new ColorConfiguration());
			modelBuilder.ApplyConfiguration(new StyleConfiguration());
			modelBuilder.ApplyConfiguration(new SexConfiguration());
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			modelBuilder.ApplyConfiguration(new MaterialConfiguration());
			modelBuilder.ApplyConfiguration(new ImageConfiguration());
			modelBuilder.ApplyConfiguration(new BillDetailsConfiguration());
			modelBuilder.ApplyConfiguration(new BillStatusHistoryConfiguration());
			modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
			modelBuilder.ApplyConfiguration(new RoleConfiguration());
			//SeedData(modelBuilder);
		}
		public static void SeedData(ModelBuilder modelBuilder)
		{
			var customers = new List<Customer>
		{
			new Customer { CustomerID = Guid.NewGuid(), FullName = "Customer 1", UserName = "customer1", Password = "password", ResetPassword = "reset1", Email = "customer1@example.com", PhoneNumber = "1234567890", Sex = "Male", DateCreated = DateTime.UtcNow },
			new Customer { CustomerID = Guid.NewGuid(), FullName = "Customer 2", UserName = "customer2", Password = "password", ResetPassword = "reset2", Email = "customer2@example.com", PhoneNumber = "0987654321", Sex = "Female", DateCreated = DateTime.UtcNow },
			new Customer { CustomerID = Guid.NewGuid(), FullName = "Customer 3", UserName = "customer3", Password = "password", ResetPassword = "reset3", Email = "customer3@example.com", PhoneNumber = "1231231234", Sex = "Male", DateCreated = DateTime.UtcNow },
			new Customer { CustomerID = Guid.NewGuid(), FullName = "Customer 4", UserName = "customer4", Password = "password", ResetPassword = "reset4", Email = "customer4@example.com", PhoneNumber = "4321432143", Sex = "Female", DateCreated = DateTime.UtcNow },
			new Customer { CustomerID = Guid.NewGuid(), FullName = "Customer 5", UserName = "customer5", Password = "password", ResetPassword = "reset5", Email = "customer5@example.com", PhoneNumber = "6789678967", Sex = "Male", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<Customer>().HasData(customers);

			var addresses = new List<Address>
		{
			new Address { AddressID = Guid.NewGuid(), Street = "Street 1", Commune = "Commune 1", District = "District 1", Province = "Province 1", Status = "Active", DateCreated = DateTime.UtcNow, IsDefaultAddress = true, ShippingCost = 10, DistrictCode = "D1", WardCode = "W1", CustomerID = customers[0].CustomerID },
			new Address { AddressID = Guid.NewGuid(), Street = "Street 2", Commune = "Commune 2", District = "District 2", Province = "Province 2", Status = "Active", DateCreated = DateTime.UtcNow, IsDefaultAddress = false, ShippingCost = 20, DistrictCode = "D2", WardCode = "W2", CustomerID = customers[1].CustomerID },
			new Address { AddressID = Guid.NewGuid(), Street = "Street 3", Commune = "Commune 3", District = "District 3", Province = "Province 3", Status = "Active", DateCreated = DateTime.UtcNow, IsDefaultAddress = true, ShippingCost = 30, DistrictCode = "D3", WardCode = "W3", CustomerID = customers[2].CustomerID },
			new Address { AddressID = Guid.NewGuid(), Street = "Street 4", Commune = "Commune 4", District = "District 4", Province = "Province 4", Status = "Active", DateCreated = DateTime.UtcNow, IsDefaultAddress = false, ShippingCost = 40, DistrictCode = "D4", WardCode = "W4", CustomerID = customers[3].CustomerID },
			new Address { AddressID = Guid.NewGuid(), Street = "Street 5", Commune = "Commune 5", District = "District 5", Province = "Province 5", Status = "Active", DateCreated = DateTime.UtcNow, IsDefaultAddress = true, ShippingCost = 50, DistrictCode = "D5", WardCode = "W5", CustomerID = customers[4].CustomerID }
		};

			modelBuilder.Entity<Address>().HasData(addresses);

			var roles = new List<Role>
		{
			new Role { RoleID = Guid.NewGuid(), RoleCode = "R1", RoleName = "Admin", DateCreated = DateTime.UtcNow },
			new Role { RoleID = Guid.NewGuid(), RoleCode = "R2", RoleName = "User", DateCreated = DateTime.UtcNow },
			new Role { RoleID = Guid.NewGuid(), RoleCode = "R3", RoleName = "Manager", DateCreated = DateTime.UtcNow },
			new Role { RoleID = Guid.NewGuid(), RoleCode = "R4", RoleName = "Support", DateCreated = DateTime.UtcNow },
			new Role { RoleID = Guid.NewGuid(), RoleCode = "R5", RoleName = "Guest", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<Role>().HasData(roles);

			var employees = new List<Employee>
		{
			new Employee { EmployeeID = Guid.NewGuid(), FullName = "Employee 1", UserName = "employee1", Password = "password", Sex = "Male", PhoneNumber = "1234567890", Email = "employee1@example.com", Status = "Active", DateCreated = DateTime.UtcNow, IdentificationCode = "ID1", Image = "img1.png", RoleID = roles[0].RoleID },
			new Employee { EmployeeID = Guid.NewGuid(), FullName = "Employee 2", UserName = "employee2", Password = "password", Sex = "Female", PhoneNumber = "0987654321", Email = "employee2@example.com", Status = "Active", DateCreated = DateTime.UtcNow, IdentificationCode = "ID2", Image = "img2.png", RoleID = roles[1].RoleID },
			new Employee { EmployeeID = Guid.NewGuid(), FullName = "Employee 3", UserName = "employee3", Password = "password", Sex = "Male", PhoneNumber = "1231231234", Email = "employee3@example.com", Status = "Active", DateCreated = DateTime.UtcNow, IdentificationCode = "ID3", Image = "img3.png", RoleID = roles[2].RoleID },
			new Employee { EmployeeID = Guid.NewGuid(), FullName = "Employee 4", UserName = "employee4", Password = "password", Sex = "Female", PhoneNumber = "4321432143", Email = "employee4@example.com", Status = "Active", DateCreated = DateTime.UtcNow, IdentificationCode = "ID4", Image = "img4.png", RoleID = roles[3].RoleID },
			new Employee { EmployeeID = Guid.NewGuid(), FullName = "Employee 5", UserName = "employee5", Password = "password", Sex = "Male", PhoneNumber = "6789678967", Email = "employee5@example.com", Status = "Active", DateCreated = DateTime.UtcNow, IdentificationCode = "ID5", Image = "img5.png", RoleID = roles[4].RoleID }
		};

			modelBuilder.Entity<Employee>().HasData(employees);

			var vouchers = new List<Voucher>
		{
			new Voucher { VoucherID = Guid.NewGuid(), VoucherCode = "VC1", VoucherValue = 100, DateCreated = DateTime.UtcNow, ExpirationDate = DateTime.UtcNow.AddMonths(1), RemainingUsage = 5, MaxUsage = 10, Status = true, Total = 1000 },
			new Voucher { VoucherID = Guid.NewGuid(), VoucherCode = "VC2", VoucherValue = 200, DateCreated = DateTime.UtcNow, ExpirationDate = DateTime.UtcNow.AddMonths(1), RemainingUsage = 4, MaxUsage = 10, Status = true, Total = 1000 },
			new Voucher { VoucherID = Guid.NewGuid(), VoucherCode = "VC3", VoucherValue = 300, DateCreated = DateTime.UtcNow, ExpirationDate = DateTime.UtcNow.AddMonths(1), RemainingUsage = 3, MaxUsage = 10, Status = true, Total = 1000 },
			new Voucher { VoucherID = Guid.NewGuid(), VoucherCode = "VC4", VoucherValue = 400, DateCreated = DateTime.UtcNow, ExpirationDate = DateTime.UtcNow.AddMonths(1), RemainingUsage = 2, MaxUsage = 10, Status = true, Total = 1000 },
			new Voucher { VoucherID = Guid.NewGuid(), VoucherCode = "VC5", VoucherValue = 500, DateCreated = DateTime.UtcNow, ExpirationDate = DateTime.UtcNow.AddMonths(1), RemainingUsage = 1, MaxUsage = 10, Status = true, Total = 1000 }
		};

			modelBuilder.Entity<Voucher>().HasData(vouchers);

			var purchaseMethods = new List<PurchaseMethod>
		{
			new PurchaseMethod { PurchaseMethodID = Guid.NewGuid(), Name = "Credit Card", Status = "Active", DateCreated = DateTime.UtcNow },
			new PurchaseMethod { PurchaseMethodID = Guid.NewGuid(), Name = "PayPal", Status = "Active", DateCreated = DateTime.UtcNow },
			new PurchaseMethod { PurchaseMethodID = Guid.NewGuid(), Name = "Cash", Status = "Active", DateCreated = DateTime.UtcNow },
			new PurchaseMethod { PurchaseMethodID = Guid.NewGuid(), Name = "Bank Transfer", Status = "Active", DateCreated = DateTime.UtcNow },
			new PurchaseMethod { PurchaseMethodID = Guid.NewGuid(), Name = "Cryptocurrency", Status = "Active", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<PurchaseMethod>().HasData(purchaseMethods);

			var bills = new List<Bill>
		{
			new Bill { ID = Guid.NewGuid(), BillCode = "B1", DateCreated = DateTime.UtcNow, SuccessDate = DateTime.UtcNow.AddDays(1), DeliveryDate = DateTime.UtcNow.AddDays(2), CancelDate = null, TotalPrice = 1000, ShippingCosts = 50, Note = "Note 1", Status = "Delivered", ConfirmationDate = DateTime.UtcNow.AddHours(1), UpdateDate = DateTime.UtcNow.AddHours(2), TotalPriceAfterDiscount = 950, PaymentDay = DateTime.UtcNow.AddHours(3), TransactionType = "Credit", IsPaid = true, VoucherID = vouchers[0].VoucherID, EmployeeID = employees[0].EmployeeID, PurchaseMethodID = purchaseMethods[0].PurchaseMethodID, CustomerID = customers[0].CustomerID },
			new Bill { ID = Guid.NewGuid(), BillCode = "B2", DateCreated = DateTime.UtcNow, SuccessDate = DateTime.UtcNow.AddDays(1), DeliveryDate = DateTime.UtcNow.AddDays(2), CancelDate = null, TotalPrice = 2000, ShippingCosts = 100, Note = "Note 2", Status = "Delivered", ConfirmationDate = DateTime.UtcNow.AddHours(1), UpdateDate = DateTime.UtcNow.AddHours(2), TotalPriceAfterDiscount = 1900, PaymentDay = DateTime.UtcNow.AddHours(3), TransactionType = "Credit", IsPaid = true, VoucherID = vouchers[1].VoucherID, EmployeeID = employees[1].EmployeeID, PurchaseMethodID = purchaseMethods[1].PurchaseMethodID, CustomerID = customers[1].CustomerID },
			new Bill { ID = Guid.NewGuid(), BillCode = "B3", DateCreated = DateTime.UtcNow, SuccessDate = DateTime.UtcNow.AddDays(1), DeliveryDate = DateTime.UtcNow.AddDays(2), CancelDate = null, TotalPrice = 3000, ShippingCosts = 150, Note = "Note 3", Status = "Delivered", ConfirmationDate = DateTime.UtcNow.AddHours(1), UpdateDate = DateTime.UtcNow.AddHours(2), TotalPriceAfterDiscount = 2850, PaymentDay = DateTime.UtcNow.AddHours(3), TransactionType = "Credit", IsPaid = true, VoucherID = vouchers[2].VoucherID, EmployeeID = employees[2].EmployeeID, PurchaseMethodID = purchaseMethods[2].PurchaseMethodID, CustomerID = customers[2].CustomerID },
			new Bill { ID = Guid.NewGuid(), BillCode = "B4", DateCreated = DateTime.UtcNow, SuccessDate = DateTime.UtcNow.AddDays(1), DeliveryDate = DateTime.UtcNow.AddDays(2), CancelDate = null, TotalPrice = 4000, ShippingCosts = 200, Note = "Note 4", Status = "Delivered", ConfirmationDate = DateTime.UtcNow.AddHours(1), UpdateDate = DateTime.UtcNow.AddHours(2), TotalPriceAfterDiscount = 3800, PaymentDay = DateTime.UtcNow.AddHours(3), TransactionType = "Credit", IsPaid = true, VoucherID = vouchers[3].VoucherID, EmployeeID = employees[3].EmployeeID, PurchaseMethodID = purchaseMethods[3].PurchaseMethodID, CustomerID = customers[3].CustomerID },
			new Bill { ID = Guid.NewGuid(), BillCode = "B5", DateCreated = DateTime.UtcNow, SuccessDate = DateTime.UtcNow.AddDays(1), DeliveryDate = DateTime.UtcNow.AddDays(2), CancelDate = null, TotalPrice = 5000, ShippingCosts = 250, Note = "Note 5", Status = "Delivered", ConfirmationDate = DateTime.UtcNow.AddHours(1), UpdateDate = DateTime.UtcNow.AddHours(2), TotalPriceAfterDiscount = 4750, PaymentDay = DateTime.UtcNow.AddHours(3), TransactionType = "Credit", IsPaid = true, VoucherID = vouchers[4].VoucherID, EmployeeID = employees[4].EmployeeID, PurchaseMethodID = purchaseMethods[4].PurchaseMethodID, CustomerID = customers[4].CustomerID }
		};

			modelBuilder.Entity<Bill>().HasData(bills);

			var billDetails = new List<BillDetails>
		{
			new BillDetails { ID = Guid.NewGuid(), BillID = bills[0].ID, ShoesDetails_SizeID = Guid.NewGuid(), Quantity = 1, Price = 1000, Status = "Delivered" },
			new BillDetails { ID = Guid.NewGuid(), BillID = bills[1].ID, ShoesDetails_SizeID = Guid.NewGuid(), Quantity = 2, Price = 2000, Status = "Delivered" },
			new BillDetails { ID = Guid.NewGuid(), BillID = bills[2].ID, ShoesDetails_SizeID = Guid.NewGuid(), Quantity = 3, Price = 3000, Status = "Delivered" },
			new BillDetails { ID = Guid.NewGuid(), BillID = bills[3].ID, ShoesDetails_SizeID = Guid.NewGuid(), Quantity = 4, Price = 4000, Status = "Delivered" },
			new BillDetails { ID = Guid.NewGuid(), BillID = bills[4].ID, ShoesDetails_SizeID = Guid.NewGuid(), Quantity = 5, Price = 5000, Status = "Delivered" }
		};

			modelBuilder.Entity<BillDetails>().HasData(billDetails);

			var billStatusHistories = new List<BillStatusHistory>
		{
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Ordered", ChangeDate = DateTime.UtcNow, Note = "Order placed", BillID = bills[0].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Shipped", ChangeDate = DateTime.UtcNow.AddHours(1), Note = "Order shipped", BillID = bills[0].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Delivered", ChangeDate = DateTime.UtcNow.AddHours(2), Note = "Order delivered", BillID = bills[0].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Ordered", ChangeDate = DateTime.UtcNow, Note = "Order placed", BillID = bills[1].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Shipped", ChangeDate = DateTime.UtcNow.AddHours(1), Note = "Order shipped", BillID = bills[1].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Delivered", ChangeDate = DateTime.UtcNow.AddHours(2), Note = "Order delivered", BillID = bills[1].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Ordered", ChangeDate = DateTime.UtcNow, Note = "Order placed", BillID = bills[2].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Shipped", ChangeDate = DateTime.UtcNow.AddHours(1), Note = "Order shipped", BillID = bills[2].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Delivered", ChangeDate = DateTime.UtcNow.AddHours(2), Note = "Order delivered", BillID = bills[2].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Ordered", ChangeDate = DateTime.UtcNow, Note = "Order placed", BillID = bills[3].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Shipped", ChangeDate = DateTime.UtcNow.AddHours(1), Note = "Order shipped", BillID = bills[3].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Delivered", ChangeDate = DateTime.UtcNow.AddHours(2), Note = "Order delivered", BillID = bills[3].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Ordered", ChangeDate = DateTime.UtcNow, Note = "Order placed", BillID = bills[4].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Shipped", ChangeDate = DateTime.UtcNow.AddHours(1), Note = "Order shipped", BillID = bills[4].ID },
			new BillStatusHistory { BillStatusHistoryID = Guid.NewGuid(), Status = "Delivered", ChangeDate = DateTime.UtcNow.AddHours(2), Note = "Order delivered", BillID = bills[4].ID }
		};

			modelBuilder.Entity<BillStatusHistory>().HasData(billStatusHistories);

			var sizes = new List<Size>
		{
			new Size { SizeID = Guid.NewGuid(), SizeCode = "S1", Name = "Size 1", Status = "Active", DateCreated = DateTime.UtcNow },
			new Size { SizeID = Guid.NewGuid(), SizeCode = "S2", Name = "Size 2", Status = "Active", DateCreated = DateTime.UtcNow },
			new Size { SizeID = Guid.NewGuid(), SizeCode = "S3", Name = "Size 3", Status = "Active", DateCreated = DateTime.UtcNow },
			new Size { SizeID = Guid.NewGuid(), SizeCode = "S4", Name = "Size 4", Status = "Active", DateCreated = DateTime.UtcNow },
			new Size { SizeID = Guid.NewGuid(), SizeCode = "S5", Name = "Size 5", Status = "Active", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<Size>().HasData(sizes);

			var colors = new List<Color>
		{
			new Color { ColorID = Guid.NewGuid(), ColorCode = "C1", Name = "Red", Status = "Active", DateCreated = DateTime.UtcNow },
			new Color { ColorID = Guid.NewGuid(), ColorCode = "C2", Name = "Blue", Status = "Active", DateCreated = DateTime.UtcNow },
			new Color { ColorID = Guid.NewGuid(), ColorCode = "C3", Name = "Green", Status = "Active", DateCreated = DateTime.UtcNow },
			new Color { ColorID = Guid.NewGuid(), ColorCode = "C4", Name = "Yellow", Status = "Active", DateCreated = DateTime.UtcNow },
			new Color { ColorID = Guid.NewGuid(), ColorCode = "C5", Name = "Black", Status = "Active", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<Color>().HasData(colors);

			var materials = new List<Material>
		{
			new Material { MaterialID = Guid.NewGuid(), MaterialCode = "M1", Name = "Leather", Status = "Active", DateCreated = DateTime.UtcNow },
			new Material { MaterialID = Guid.NewGuid(), MaterialCode = "M2", Name = "Suede", Status = "Active", DateCreated = DateTime.UtcNow },
			new Material { MaterialID = Guid.NewGuid(), MaterialCode = "M3", Name = "Canvas", Status = "Active", DateCreated = DateTime.UtcNow },
			new Material { MaterialID = Guid.NewGuid(), MaterialCode = "M4", Name = "Synthetic", Status = "Active", DateCreated = DateTime.UtcNow },
			new Material { MaterialID = Guid.NewGuid(), MaterialCode = "M5", Name = "Rubber", Status = "Active", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<Material>().HasData(materials);

			var products = new List<Product>
		{
			new Product { ProductID = Guid.NewGuid(), ProductCode = "P1", Name = "Running Shoes", Status = "Active", DateCreated = DateTime.UtcNow },
			new Product { ProductID = Guid.NewGuid(), ProductCode = "P2", Name = "Sneakers", Status = "Active", DateCreated = DateTime.UtcNow },
			new Product { ProductID = Guid.NewGuid(), ProductCode = "P3", Name = "Boots", Status = "Active", DateCreated = DateTime.UtcNow },
			new Product { ProductID = Guid.NewGuid(), ProductCode = "P4", Name = "Sandals", Status = "Active", DateCreated = DateTime.UtcNow },
			new Product { ProductID = Guid.NewGuid(), ProductCode = "P5", Name = "Formal Shoes", Status = "Active", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<Product>().HasData(products);

			var images = new List<Image>
		{
			new Image { ImageID = Guid.NewGuid(), ImageCode = "IMG1", Name = "Image 1", Status = "Active", ImageUrl1 = "https://example.com/img1_1.jpg", ImageUrl2 = "https://example.com/img1_2.jpg", ImageUrl3 = "https://example.com/img1_3.jpg", ImageUrl4 = "https://example.com/img1_4.jpg", DateCreated = DateTime.UtcNow },
			new Image { ImageID = Guid.NewGuid(), ImageCode = "IMG2", Name = "Image 2", Status = "Active", ImageUrl1 = "https://example.com/img2_1.jpg", ImageUrl2 = "https://example.com/img2_2.jpg", ImageUrl3 = "https://example.com/img2_3.jpg", ImageUrl4 = "https://example.com/img2_4.jpg", DateCreated = DateTime.UtcNow },
			new Image { ImageID = Guid.NewGuid(), ImageCode = "IMG3", Name = "Image 3", Status = "Active", ImageUrl1 = "https://example.com/img3_1.jpg", ImageUrl2 = "https://example.com/img3_2.jpg", ImageUrl3 = "https://example.com/img3_3.jpg", ImageUrl4 = "https://example.com/img3_4.jpg", DateCreated = DateTime.UtcNow },
			new Image { ImageID = Guid.NewGuid(), ImageCode = "IMG4", Name = "Image 4", Status = "Active", ImageUrl1 = "https://example.com/img4_1.jpg", ImageUrl2 = "https://example.com/img4_2.jpg", ImageUrl3 = "https://example.com/img4_3.jpg", ImageUrl4 = "https://example.com/img4_4.jpg", DateCreated = DateTime.UtcNow },
			new Image { ImageID = Guid.NewGuid(), ImageCode = "IMG5", Name = "Image 5", Status = "Active", ImageUrl1 = "https://example.com/img5_1.jpg", ImageUrl2 = "https://example.com/img5_2.jpg", ImageUrl3 = "https://example.com/img5_3.jpg", ImageUrl4 = "https://example.com/img5_4.jpg", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<Image>().HasData(images);

			var sexes = new List<Sex>
		{
			new Sex { SexID = Guid.NewGuid(), SexName = "Male" },
			new Sex { SexID = Guid.NewGuid(), SexName = "Female" },
			new Sex { SexID = Guid.NewGuid(), SexName = "Unisex" },
			new Sex { SexID = Guid.NewGuid(), SexName = "Kids" },
			new Sex { SexID = Guid.NewGuid(), SexName = "Others" }
		};

			modelBuilder.Entity<Sex>().HasData(sexes);

			var styles = new List<Style>
		{
			new Style { StyleID = Guid.NewGuid(), StyleCode = "ST1", Name = "Casual", Status = "Active", DateCreated = DateTime.UtcNow },
			new Style { StyleID = Guid.NewGuid(), StyleCode = "ST2", Name = "Sport", Status = "Active", DateCreated = DateTime.UtcNow },
			new Style { StyleID = Guid.NewGuid(), StyleCode = "ST3", Name = "Formal", Status = "Active", DateCreated = DateTime.UtcNow },
			new Style { StyleID = Guid.NewGuid(), StyleCode = "ST4", Name = "Outdoor", Status = "Active", DateCreated = DateTime.UtcNow },
			new Style { StyleID = Guid.NewGuid(), StyleCode = "ST5", Name = "Work", Status = "Active", DateCreated = DateTime.UtcNow }
		};

			modelBuilder.Entity<Style>().HasData(styles);

			var shoesDetails = new List<ShoesDetails>
		{
			new ShoesDetails { ShoesDetailsID = Guid.NewGuid(), ShoesDetailsCode = "SD1", Price = 1000, ImportPrice = 800, Description = "Running Shoes", Status = "Active", ColorID = colors[0].ColorID, ProductID = products[0].ProductID, StyleID = styles[0].StyleID, SexID = sexes[0].SexID, MaterialID = materials[0].MaterialID, ImageID = images[0].ImageID, ShoesDetails_SizeID = Guid.NewGuid() },
			new ShoesDetails { ShoesDetailsID = Guid.NewGuid(), ShoesDetailsCode = "SD2", Price = 2000, ImportPrice = 1600, Description = "Sneakers", Status = "Active", ColorID = colors[1].ColorID, ProductID = products[1].ProductID, StyleID = styles[1].StyleID, SexID = sexes[1].SexID, MaterialID = materials[1].MaterialID, ImageID = images[1].ImageID, ShoesDetails_SizeID = Guid.NewGuid() },
			new ShoesDetails { ShoesDetailsID = Guid.NewGuid(), ShoesDetailsCode = "SD3", Price = 3000, ImportPrice = 2400, Description = "Boots", Status = "Active", ColorID = colors[2].ColorID, ProductID = products[2].ProductID, StyleID = styles[2].StyleID, SexID = sexes[2].SexID, MaterialID = materials[2].MaterialID, ImageID = images[2].ImageID, ShoesDetails_SizeID = Guid.NewGuid() },
			new ShoesDetails { ShoesDetailsID = Guid.NewGuid(), ShoesDetailsCode = "SD4", Price = 4000, ImportPrice = 3200, Description = "Sandals", Status = "Active", ColorID = colors[3].ColorID, ProductID = products[3].ProductID, StyleID = styles[3].StyleID, SexID = sexes[3].SexID, MaterialID = materials[3].MaterialID, ImageID = images[3].ImageID, ShoesDetails_SizeID = Guid.NewGuid() },
			new ShoesDetails { ShoesDetailsID = Guid.NewGuid(), ShoesDetailsCode = "SD5", Price = 5000, ImportPrice = 4000, Description = "Formal Shoes", Status = "Active", ColorID = colors[4].ColorID, ProductID = products[4].ProductID, StyleID = styles[4].StyleID, SexID = sexes[4].SexID, MaterialID = materials[4].MaterialID, ImageID = images[4].ImageID, ShoesDetails_SizeID = Guid.NewGuid() }
		};

			modelBuilder.Entity<ShoesDetails>().HasData(shoesDetails);

			var shoesDetailsSizes = new List<ShoesDetails_Size>
		{
			new ShoesDetails_Size { ID = Guid.NewGuid(), ShoesDetailsID = shoesDetails[0].ShoesDetailsID, SizeID = sizes[0].SizeID, Quantity = 10 },
			new ShoesDetails_Size { ID = Guid.NewGuid(), ShoesDetailsID = shoesDetails[1].ShoesDetailsID, SizeID = sizes[1].SizeID, Quantity = 20 },
			new ShoesDetails_Size { ID = Guid.NewGuid(), ShoesDetailsID = shoesDetails[2].ShoesDetailsID, SizeID = sizes[2].SizeID, Quantity = 30 },
			new ShoesDetails_Size { ID = Guid.NewGuid(), ShoesDetailsID = shoesDetails[3].ShoesDetailsID, SizeID = sizes[3].SizeID, Quantity = 40 },
			new ShoesDetails_Size { ID = Guid.NewGuid(), ShoesDetailsID = shoesDetails[4].ShoesDetailsID, SizeID = sizes[4].SizeID, Quantity = 50 }
		};

			modelBuilder.Entity<ShoesDetails_Size>().HasData(shoesDetailsSizes);

			var carts = new List<Cart>
		{
			new Cart { CartID = Guid.NewGuid(), CustomerID = customers[0].CustomerID, Description = "Customer 1's Cart" },
			new Cart { CartID = Guid.NewGuid(), CustomerID = customers[1].CustomerID, Description = "Customer 2's Cart" },
			new Cart { CartID = Guid.NewGuid(), CustomerID = customers[2].CustomerID, Description = "Customer 3's Cart" },
			new Cart { CartID = Guid.NewGuid(), CustomerID = customers[3].CustomerID, Description = "Customer 4's Cart" },
			new Cart { CartID = Guid.NewGuid(), CustomerID = customers[4].CustomerID, Description = "Customer 5's Cart" }
		};

			modelBuilder.Entity<Cart>().HasData(carts);

			var cartDetails = new List<CartDetails>
		{
			new CartDetails { ID = Guid.NewGuid(), ShoesDetails_SizeID = shoesDetailsSizes[0].ID, Quantity = 1, CartID = carts[0].CartID },
			new CartDetails { ID = Guid.NewGuid(), ShoesDetails_SizeID = shoesDetailsSizes[1].ID, Quantity = 2, CartID = carts[1].CartID },
			new CartDetails { ID = Guid.NewGuid(), ShoesDetails_SizeID = shoesDetailsSizes[2].ID, Quantity = 3, CartID = carts[2].CartID },
			new CartDetails { ID = Guid.NewGuid(), ShoesDetails_SizeID = shoesDetailsSizes[3].ID, Quantity = 4, CartID = carts[3].CartID },
			new CartDetails { ID = Guid.NewGuid(), ShoesDetails_SizeID = shoesDetailsSizes[4].ID, Quantity = 5, CartID = carts[4].CartID }
		};

			modelBuilder.Entity<CartDetails>().HasData(cartDetails);
		}
	}

}
