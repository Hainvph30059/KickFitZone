using APP_DATA.Context;
using APP_Service.Repositories.Implementations;
using APP_Service.Repositories.UnitOfWork;
using APP_Service.Services.Implementations;
using APP_Service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

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
			#endregion

			#region Add Dependency Injection
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
			builder.Services.AddScoped<IAddressService, AddressService>();
			builder.Services.AddScoped<IBillService, BillService>();
			builder.Services.AddScoped<ICustomerService, CustomerService>();
			builder.Services.AddScoped<IEmployeeService, EmployeeService>();
			builder.Services.AddScoped<IProductService, ProductService>();
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

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
