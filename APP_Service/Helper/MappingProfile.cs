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
			CreateMap<BillStatusHistory, BillStatusHistoryDto>().ReverseMap();
			CreateMap<BillDetails, BillDetailDto>().ReverseMap();
			CreateMap<Cart, CartDto>().ReverseMap();
			CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
			CreateMap<Color, ColorDto>().ReverseMap();
			CreateMap<Customer, CustomerDto>().ReverseMap();
			CreateMap<Employee, EmployeeDto>().ReverseMap();
			CreateMap<Image, ImageDto>().ReverseMap();
			CreateMap<Material, MaterialDto>().ReverseMap();
			CreateMap<Product, ProductDto>().ReverseMap();
			CreateMap<PurchaseMethod, PurchaseMethodDto>().ReverseMap();
			CreateMap<Role, RoleDto>().ReverseMap();
			CreateMap<Sex, SexDto>().ReverseMap();
			CreateMap<ShoesDetails, ShoesDetailsDto>().ReverseMap();
			CreateMap<Size, SizeDto>().ReverseMap();
			CreateMap<Style, StyleDto>().ReverseMap();
			CreateMap<Voucher, VouchersDto>().ReverseMap();
		}
	}
}
