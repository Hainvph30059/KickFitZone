using APP_DATA.ClassDTO;
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
			if (entity == null || _unitOfWork.Employee.GetByID(entity.EmployeeID) != null)
			{
				return false;
			}
			if (_unitOfWork.Role.GetByID(entity.RoleID) == null) return false;
			entity.Password = PasswordHasher.HashPassword(entity.Password);
			entity.EmployeeID = Guid.NewGuid();
			_unitOfWork.Employee.Create(_mapper.Map<Employee>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var employee = _unitOfWork.Employee.GetByID(ID);
			if (employee == null) { return false; }
			_unitOfWork.Employee.Delete(employee);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<EmployeeDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<EmployeeDto>();

			var employee = _unitOfWork.Employee.Find(c => c.FullName.Contains(keyWord));
			if (employee == null || !employee.Any())
				return Enumerable.Empty<EmployeeDto>();

			return _mapper.Map<IEnumerable<EmployeeDto>>(employee);
		}

		public async Task<IEnumerable<EmployeeDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Employee.GetAllAsync();
			var employeeDto = _mapper.Map<IEnumerable<EmployeeDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				employeeDto = employeeDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return employeeDto;
		}

		public EmployeeDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var employee = _unitOfWork.Employee.GetByID(ID);
			if (employee == null)
				return null;

			return _mapper.Map<EmployeeDto>(employee);
		}

		public bool Update(EmployeeDto entity)
		{
			if (entity == null)
				return false;

			var existingEmployee = _unitOfWork.Employee.GetByID(entity.EmployeeID);
			if (existingEmployee == null)
				return false;
			entity.Password = PasswordHasher.HashPassword(entity.Password);
			_mapper.Map(entity, existingEmployee);

			_unitOfWork.Employee.Update(existingEmployee);
			_unitOfWork.Save();

			return true;
		}
	}
}
