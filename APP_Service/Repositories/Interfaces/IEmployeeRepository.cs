﻿using APP_DATA.Entites;
using APP_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Repositories.Interfaces
{
	public interface IEmployeeRepository : IGenericRepository<Employee>
	{
		public Employee GetEmployeeToLogin(LoginRequest loginRequet);
	}
}
