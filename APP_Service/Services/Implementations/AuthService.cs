using APP_DATA.Entites;
using APP_Service.Helper;
using APP_Service.Repositories.UnitOfWork;
using APP_Service.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Services.Implementations
{
	public class AuthService : IAuthService
	{
	    private IUnitOfWork _unitOfWork;
		private IConfiguration _configuration;

		public AuthService(IUnitOfWork unitOfWork, IConfiguration configuration)
		{
			_unitOfWork = unitOfWork;
			_configuration = configuration;
		}

		public string Login(LoginRequest loginRequest)
		{
			
			var customer = _unitOfWork.Customer.GetCustomerToLogin(loginRequest);

			if(customer != null && PasswordHasher.VerifyPassword(loginRequest.password, customer.Password))
			{
				var token = GenerateToken(customer.UserName, "customer");
				return token.ToString();
			}

			var employee = _unitOfWork.Employee.GetEmployeeToLogin(loginRequest);
			if (employee != null && PasswordHasher.VerifyPassword(loginRequest.password, employee.Password))
			{
				var token = GenerateToken(employee.UserName, employee.Role.RoleName);
				return token.ToString();
			}

			return string.Empty;
		}

		private string GenerateToken(string username, string role)
		{
			var claims = new[]
			{
			new Claim(JwtRegisteredClaimNames.Sub, username),
			new Claim(ClaimTypes.Role, role)
		};

			var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
			// Tạo một token
			var token = new JwtSecurityToken(
				issuer: _configuration["JWT:ValidIssuer"],
				audience: _configuration["JWT:ValidAudience"],
				claims: claims,
				signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature),	
				expires: DateTime.Now.AddMinutes(20)
				);
			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
