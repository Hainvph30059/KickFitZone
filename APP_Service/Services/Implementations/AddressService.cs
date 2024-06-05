using APP_DATA.ClassDTO;
using APP_DATA.Entity;
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
	public class AddressService : IAddressService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public AddressService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(AddressDto entity)
		{
			if (entity == null || _unitOfWork.Customer.GetByID(entity.CustomerID) == null)
			{
				return false; 
			}
			if(_unitOfWork.Address.GetByID(entity.AddressID) != null) 
			{
				return false;
			}
			entity.AddressID = Guid.NewGuid();
			_unitOfWork.Address.Create(_mapper.Map<Address>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if(ID == Guid.Empty) { return false; }
			var address = _unitOfWork.Address.GetByID(ID);
			if(address == null) { return false; }
			_unitOfWork.Address.Delete(address);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<AddressDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<AddressDto>();

			var addresses = _unitOfWork.Address.Find(c => c.Street.Contains(keyWord));
			if (addresses == null || !addresses.Any())
				return Enumerable.Empty<AddressDto>();

			return _mapper.Map<IEnumerable<AddressDto>>(addresses);
		}

		public async Task<IEnumerable<AddressDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Address.GetAllAsync();
			var addressDto = _mapper.Map<IEnumerable<AddressDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				addressDto = addressDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return addressDto;
		}

		public AddressDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var address = _unitOfWork.Address.GetByID(ID);
			if (address == null)
				return null;

			return _mapper.Map<AddressDto>(address);
		}

		public bool Update(AddressDto entity)
		{
			if (entity == null)
				return false;

			var existingAddress = _unitOfWork.Address.GetByID(entity.AddressID);
			if (existingAddress == null)
				return false;
			entity.CustomerID = existingAddress.CustomerID;
			// Cập nhật các thuộc tính của thực thể đã tồn tại từ thực thể DTO
			_mapper.Map(entity, existingAddress);

			_unitOfWork.Address.Update(existingAddress);
			_unitOfWork.Save();

			return true;
		}
	}
}
