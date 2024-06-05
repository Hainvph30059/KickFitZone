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
    public class SexService : ISexService
    {
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public SexService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(SexDto entity)
		{
			if (entity == null || _unitOfWork.Sex.GetByID(entity.SexID) != null)
			{
				return false;
			}
			entity.SexID = Guid.NewGuid();
			_unitOfWork.Sex.Create(_mapper.Map<Sex>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var sex = _unitOfWork.Sex.GetByID(ID);
			if (sex == null) { return false; }
			_unitOfWork.Sex.Delete(sex);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<SexDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<SexDto>();

			var sex = _unitOfWork.Sex.Find(c => c.SexName.Contains(keyWord));
			if (sex == null || !sex.Any())
				return Enumerable.Empty<SexDto>();

			return _mapper.Map<IEnumerable<SexDto>>(sex);
		}

		public async Task<IEnumerable<SexDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Sex.GetAllAsync();
			var sexDto = _mapper.Map<IEnumerable<SexDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				sexDto = sexDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return sexDto;
		}

		public SexDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var sex = _unitOfWork.Sex.GetByID(ID);
			if (sex == null)
				return null;

			return _mapper.Map<SexDto>(sex);
		}

		public bool Update(SexDto entity)
		{
			if (entity == null)
				return false;

			var existingSex = _unitOfWork.Sex.GetByID(entity.SexID);
			if (existingSex == null)
				return false;

			_mapper.Map(entity, existingSex);

			_unitOfWork.Sex.Update(existingSex);
			_unitOfWork.Save();

			return true;
		}
	}
}
