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
	public class BillService : IBillService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public BillService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
		public bool Create(BillDto entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(Guid ID)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<BillDto> Find(string keyWord)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<BillDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			    var lst = await _unitOfWork.Bill.GetAllAsync();
				var billDto = _mapper.Map<IEnumerable<BillDto>>(lst);

				if (pageNumber.HasValue && pageSize.HasValue)
				{
					int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
					billDto = billDto.Skip(skipAmount).Take(pageSize.Value);
				}

				return billDto;
		}

		public BillDto GetByID(Guid ID)
		{
			throw new NotImplementedException();
		}

		public bool Update(BillDto entity)
		{
			throw new NotImplementedException();
		}
	}
}
