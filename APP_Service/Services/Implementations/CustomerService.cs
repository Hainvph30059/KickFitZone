using APP_DATA.ClassDTO;
using APP_DATA.Entites;
using APP_DATA.Entity;
using APP_Service.Helper;
using APP_Service.Repositories.UnitOfWork;
using APP_Service.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Services.Implementations
{
	public class CustomerService : ICustomerService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(CustomerDto entity)
		{
			if (entity == null || _unitOfWork.Customer.GetByID(entity.CustomerID) != null)
			{
				return false;
			}
			entity.Password = PasswordHasher.HashPassword(entity.Password);
			entity.CustomerID = Guid.NewGuid();
			// create Customer' cart
			var cart = new Cart
			{
				CartID = Guid.NewGuid(),
				CustomerID = entity.CustomerID,
			};
			_unitOfWork.Customer.Create(_mapper.Map<Customer>(entity));
			_unitOfWork.Save();
			_unitOfWork.Cart.Create(cart);
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var customer = _unitOfWork.Customer.GetByID(ID);
			if (customer == null) { return false; }
			_unitOfWork.Customer.Delete(customer);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<CustomerDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<CustomerDto>();

			var customer = _unitOfWork.Customer.Find(c => c.FullName.Contains(keyWord));
			if (customer == null || !customer.Any())
				return Enumerable.Empty<CustomerDto>();

			return _mapper.Map<IEnumerable<CustomerDto>>(customer);
		}

		public async Task<IEnumerable<CustomerDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Customer.GetAllAsync();
			var customerDto = _mapper.Map<IEnumerable<CustomerDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				customerDto = customerDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return customerDto;
		}

		public CustomerDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var customer = _unitOfWork.Customer.GetByID(ID);
			if (customer == null)
				return null;

			return _mapper.Map<CustomerDto>(customer);
		}


		public bool Update(CustomerDto entity)
		{
			if (entity == null)
				return false;

			var existingCustomer = _unitOfWork.Customer.GetByID(entity.CustomerID);
			if (existingCustomer == null)
				return false;
			entity.Password = PasswordHasher.HashPassword(entity.Password);
			_mapper.Map(entity, existingCustomer);

			_unitOfWork.Customer.Update(existingCustomer);
			_unitOfWork.Save();

			return true;
		}
	}
}
