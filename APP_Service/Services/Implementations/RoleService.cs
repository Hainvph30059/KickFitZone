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
	public class RoleService : IRoleService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public RoleService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(RoleDto entity)
		{
			if (entity == null || _unitOfWork.Role.GetByID(entity.RoleID) != null)
			{
				return false;
			}
			entity.RoleID = Guid.NewGuid();
			_unitOfWork.Role.Create(_mapper.Map<Role>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var role = _unitOfWork.Role.GetByID(ID);
			if (role == null) { return false; }
			_unitOfWork.Role.Delete(role);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<RoleDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<RoleDto>();

			var role = _unitOfWork.Role.Find(c => c.RoleName.Contains(keyWord));
			if (role == null || !role.Any())
				return Enumerable.Empty<RoleDto>();

			return _mapper.Map<IEnumerable<RoleDto>>(role);
		}

		public async Task<IEnumerable<RoleDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Role.GetAllAsync();
			var roleDto = _mapper.Map<IEnumerable<RoleDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				roleDto = roleDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return roleDto;
		}

		public RoleDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var role = _unitOfWork.Role.GetByID(ID);
			if (role == null)
				return null;

			return _mapper.Map<RoleDto>(role);
		}

		public bool Update(RoleDto entity)
		{
			if (entity == null)
				return false;

			var existingRole = _unitOfWork.Role.GetByID(entity.RoleID);
			if (existingRole == null)
				return false;

			_mapper.Map(entity, existingRole);

			_unitOfWork.Role.Update(existingRole);
			_unitOfWork.Save();

			return true;
		}
	}
}
