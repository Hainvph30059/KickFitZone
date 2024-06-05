using APP_DATA.Context;
using APP_DATA.Entites;
using APP_DATA.Entity;
using APP_Service.Helper;
using APP_Service.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Repositories.Implementations
{
	public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
	{
		public CustomerRepository(MyContext context) : base(context)
		{
		}

		public Customer GetCustomerToLogin(LoginRequest loginRequet)
		{
			return _context.Customers.FirstOrDefault(c => c.UserName == loginRequet.userName); ;	
		}
	}
}
