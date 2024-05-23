using APP_DATA.ClassDTO;
using APP_DATA.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Helper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Address, AddressDto>().ReverseMap();
			CreateMap<Bill, BillDto>().ReverseMap();
			CreateMap<Customer, CustomerDto>().ReverseMap();
			CreateMap<Employee, EmployeeDto>().ReverseMap();
			CreateMap<Product, ProductDto>().ReverseMap();
		}
	}
}
