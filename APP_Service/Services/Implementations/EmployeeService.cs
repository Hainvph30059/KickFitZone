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
	public class EmployeeService : IEmployeeService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(EmployeeDto entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(Guid ID)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<EmployeeDto> Find(string keyWord)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<EmployeeDto>> GetAllAsync(int pageNumber, int pageSize)
		{
			try
			{
				int skipAmount = (pageNumber - 1) * pageSize;
				var lst = await _unitOfWork.Employee.GetAllAsync();
				var addressDto = _mapper.Map<IEnumerable<EmployeeDto>>(lst);
				var result = addressDto.Skip(skipAmount).Take(pageSize);
				return result;
			}
			catch (Exception ex)
			{
				throw new Exception("Error: " + ex);
			}
		}

		public EmployeeDto GetByID(Guid ID)
		{
			throw new NotImplementedException();
		}

		public bool Update(EmployeeDto entity)
		{
			throw new NotImplementedException();
		}
	}
}
