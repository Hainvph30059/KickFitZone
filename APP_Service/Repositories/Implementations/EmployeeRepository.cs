using APP_DATA.Context;
using APP_DATA.Entites;
using APP_DATA.Entity;
using APP_Service.Helper;
using APP_Service.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Repositories.Implementations
{
	internal class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(MyContext context) : base(context)
		{
		}

		public Employee GetEmployeeToLogin(LoginRequest loginRequet)
		{	
			return _context.Employees.Include(r => r.Role).FirstOrDefault(c => c.UserName == loginRequet.userName);
		}
	}
}
