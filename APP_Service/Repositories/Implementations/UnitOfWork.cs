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
        }

        public IAddressRepository Address { get; private set; }

		public IBillRepository Bill { get; private set; }

		public ICustomerRepository Customer { get; private set; }

		public IEmployeeRepository Employee { get; private set; }

		public IProductRepository Product { get; private set; }

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
