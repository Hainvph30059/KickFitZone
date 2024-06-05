using APP_API.Middleware;
using APP_DATA.Context;
using APP_Service.Repositories.Implementations;
using APP_Service.Repositories.UnitOfWork;
using APP_Service.Services.Implementations;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace APP_API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			#region My Config
			builder.Services.AddDbContext<MyContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("MyCS"));
			});
			builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
			// Config JWWT Bear options
			builder.Services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(options =>
			{
				options.SaveToken = true;
				options.RequireHttpsMetadata = true;
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidAudience = builder.Configuration["JWT:ValidAudience"],
					ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
				};
			});
			#endregion

			#region Add Dependency Injection
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
			builder.Services.AddScoped<IAddressService, AddressService>();
			builder.Services.AddScoped<IBillService, BillService>();
			builder.Services.AddScoped<ICustomerService, CustomerService>();
			builder.Services.AddScoped<IEmployeeService, EmployeeService>();
			builder.Services.AddScoped<IProductService, ProductService>();
			builder.Services.AddScoped<IColorService, ColorService>();
			builder.Services.AddScoped<IStyleService, StyleService>();
			builder.Services.AddScoped<ISexService, SexService>();
			builder.Services.AddScoped<IMaterialService, MaterialService>();
			builder.Services.AddScoped<ISizeService, SizeService>();
			builder.Services.AddScoped<IPurcharMethodService, PurchaseMethodService>();
			builder.Services.AddScoped<IVoucherService, VoucherService>();
			builder.Services.AddScoped<IRoleService, RoleService>();
			builder.Services.AddScoped<IShoeDetailsService, ShoeDetailsService>();
			builder.Services.AddScoped<IAuthService, AuthService>();
			#endregion


			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}
			app.UseMiddleware<ExceptionHandlingMiddleware>();
			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
