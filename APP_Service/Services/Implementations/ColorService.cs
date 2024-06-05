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
	public class ColorService : IColorService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public ColorService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(ColorDto entity)
		{
			if (entity == null || _unitOfWork.Color.GetByID(entity.ColorID) != null)
			{
				return false;
			}
			entity.ColorID = Guid.NewGuid();
			_unitOfWork.Color.Create(_mapper.Map<Color>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var color = _unitOfWork.Color.GetByID(ID);
			if (color == null) { return false; }
			_unitOfWork.Color.Delete(color);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<ColorDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<ColorDto>();

			var color = _unitOfWork.Color.Find(c => c.Name.Contains(keyWord));
			if (color == null || !color.Any())
				return Enumerable.Empty<ColorDto>();

			return _mapper.Map<IEnumerable<ColorDto>>(color);
		}

		public async Task<IEnumerable<ColorDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Color.GetAllAsync();
			var colorDto = _mapper.Map<IEnumerable<ColorDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				colorDto = colorDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return colorDto;
		}

		public ColorDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var color = _unitOfWork.Color.GetByID(ID);
			if (color == null)
				return null;

			return _mapper.Map<ColorDto>(color);
		}

		public bool Update(ColorDto entity)
		{
			if (entity == null)
				return false;

			var existingColor = _unitOfWork.Color.GetByID(entity.ColorID);
			if (existingColor == null)
				return false;	

			_mapper.Map(entity, existingColor);

			_unitOfWork.Color.Update(existingColor);
			_unitOfWork.Save();

			return true;
		}
	}
}
