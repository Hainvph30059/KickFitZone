using APP_DATA.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Services.Interfaces
{
	public interface IAuthService
	{
		public string Login(LoginRequest loginRequest);
	}
}
