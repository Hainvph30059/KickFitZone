using APP_DATA.ClassDTO;
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
			throw new NotImplementedException();
		}

		public bool Delete(Guid ID)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<AddressDto> Find(string keyWord)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<AddressDto>> GetAllAsync(int pageNumber, int pageSize)
		{
			try
			{
				int skipAmount = (pageNumber - 1) * pageSize;
				var lst = await _unitOfWork.Address.GetAllAsync();
				var addressDto = _mapper.Map<IEnumerable<AddressDto>>(lst);
				var result = addressDto.Skip(skipAmount).Take(pageSize);
				return result;
			}
			catch (Exception ex)
			{
				throw new Exception("Error: " + ex);
			}
		}

		public AddressDto GetByID(Guid ID)
		{
			throw new NotImplementedException();
		}

		public bool Update(AddressDto entity)
		{
			throw new NotImplementedException();
		}
	}
}
