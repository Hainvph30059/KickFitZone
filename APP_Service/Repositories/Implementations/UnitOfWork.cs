using APP_DATA.Context;
using APP_Service.Repositories.Interfaces;
using APP_Service.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        internal readonly MyContext _context;

        public UnitOfWork(MyContext context)
        {
            _context = context;
            Address = new AddressRepository(context);
            Bill = new BillRepository(context);
            Customer = new CustomerRepository(context);
            Employee = new EmployeeRepository(context);
            Product = new ProductRepository(context);
			BillStatusHistory = new BillStatusHistoryRepository(context);
			Cart = new CartRepository(context);
			CartDetail = new CartDetailsRepository(context);
			Color = new ColorRepository(context);
			Image = new ImageRepository(context);
			Style = new StyleRepository(context);
			Material = new MaterialRepository(context);
			PurchaseMethod = new PurcharMethodRepository(context);
			Sex = new SexRepository(context);
			Role = new RoleRepository(context);
			ShoesDetail = new ShoesDetailsRepository(context);
			Voucher = new VoucherRepository(context);
			BillDetails = new BillDetailsRepository(context);
			Size = new SizeRepository(context);
		}

        public IAddressRepository Address { get; private set; }

		public IBillRepository Bill { get; private set; }

		public ICustomerRepository Customer { get; private set; }

		public IEmployeeRepository Employee { get; private set; }

		public IProductRepository Product { get; private set; }

		public IBillStatusHistoryRepository BillStatusHistory { get; private set; }

		public ICartRepository Cart { get; private set; }

		public ICartDetailRepository CartDetail { get; private set; }

		public IColorRepository Color { get; private set; }

		public IImageRepository Image { get; private set; }

		public IMaterialRepository Material { get; private set; }

		public IPurchaseMethodRepository PurchaseMethod { get; private set; }

		public IRoleRepository Role { get; private set; }

		public ISexRepository Sex { get; private set; }

		public IShoesDetailRepository ShoesDetail { get; private set; }

		public ISizeRepository Size { get; private set; }

		public IStyleRepository Style { get; private set; }

		public IVoucherRepository Voucher { get; private set; }

		public IBillDetailsRepository BillDetails { get; private set; }

		public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
