using APP_DATA.ClassDTO;
using APP_DATA.Entity;
using APP_Service.Repositories.Interfaces;
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
	public class MaterialService : IMaterialService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public MaterialService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(MaterialDto entity)
		{
			if (entity == null || _unitOfWork.Material.GetByID(entity.MaterialID) != null)
			{
				return false;
			}
			entity.MaterialID = Guid.NewGuid();
			_unitOfWork.Material.Create(_mapper.Map<Material>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var material = _unitOfWork.Material.GetByID(ID);
			if (material == null) { return false; }
			_unitOfWork.Material.Delete(material);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<MaterialDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<MaterialDto>();

			var material = _unitOfWork.Material.Find(c => c.Name.Contains(keyWord));
			if (material == null || !material.Any())
				return Enumerable.Empty<MaterialDto>();

			return _mapper.Map<IEnumerable<MaterialDto>>(material);
		}

		public async Task<IEnumerable<MaterialDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Material.GetAllAsync();
			var materialDto = _mapper.Map<IEnumerable<MaterialDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				materialDto = materialDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return materialDto;
		}

		public MaterialDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var material = _unitOfWork.Material.GetByID(ID);
			if (material == null)
				return null;

			return _mapper.Map<MaterialDto>(material);
		}

		public bool Update(MaterialDto entity)
		{
			if (entity == null)
				return false;

			var existingMaterial = _unitOfWork.Material.GetByID(entity.MaterialID);
			if (existingMaterial == null)
				return false;

			_mapper.Map(entity, existingMaterial);

			_unitOfWork.Material.Update(existingMaterial);
			_unitOfWork.Save();

			return true;
		}
	}
}
