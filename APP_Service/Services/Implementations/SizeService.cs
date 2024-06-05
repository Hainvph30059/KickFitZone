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
	public class SizeService : ISizeService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public SizeService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(SizeDto entity)
		{
			if (entity == null || _unitOfWork.Size.GetByID(entity.SizeID) != null)
			{
				return false;
			}
			entity.SizeID = Guid.NewGuid();
			_unitOfWork.Size.Create(_mapper.Map<Size>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var size = _unitOfWork.Size.GetByID(ID);
			if (size == null) { return false; }
			_unitOfWork.Size.Delete(size);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<SizeDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<SizeDto>();

			var size = _unitOfWork.Size.Find(c => c.Name.Contains(keyWord));
			if (size == null || !size.Any())
				return Enumerable.Empty<SizeDto>();

			return _mapper.Map<IEnumerable<SizeDto>>(size);
		}

		public async Task<IEnumerable<SizeDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Size.GetAllAsync();
			var sizeDto = _mapper.Map<IEnumerable<SizeDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				sizeDto = sizeDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return sizeDto;
		}

		public SizeDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var size = _unitOfWork.Size.GetByID(ID);
			if (size == null)
				return null;

			return _mapper.Map<SizeDto>(size);
		}

		public bool Update(SizeDto entity)
		{
			if (entity == null)
				return false;

			var existingSize = _unitOfWork.Size.GetByID(entity.SizeID);
			if (existingSize == null)
				return false;

			_mapper.Map(entity, existingSize);

			_unitOfWork.Size.Update(existingSize);
			_unitOfWork.Save();

			return true;
		}
	}
}
