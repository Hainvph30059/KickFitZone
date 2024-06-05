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
	public class StyleService : IStyleService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public StyleService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(StyleDto entity)
		{
			if (entity == null || _unitOfWork.Style.GetByID(entity.StyleID) != null)
			{
				return false;
			}
			entity.StyleID = Guid.NewGuid();
			_unitOfWork.Style.Create(_mapper.Map<Style>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var style = _unitOfWork.Style.GetByID(ID);
			if (style == null) { return false; }
			_unitOfWork.Style.Delete(style);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<StyleDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<StyleDto>();

			var style = _unitOfWork.Style.Find(c => c.Name.Contains(keyWord));
			if (style == null || !style.Any())
				return Enumerable.Empty<StyleDto>();

			return _mapper.Map<IEnumerable<StyleDto>>(style);
		}

		public async Task<IEnumerable<StyleDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Style.GetAllAsync();
			var styleDto = _mapper.Map<IEnumerable<StyleDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				styleDto = styleDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return styleDto;
		}

		public StyleDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var style = _unitOfWork.Style.GetByID(ID);
			if (style == null)
				return null;

			return _mapper.Map<StyleDto>(style);
		}

		public bool Update(StyleDto entity)
		{
			if (entity == null)
				return false;

			var existingStyle = _unitOfWork.Style.GetByID(entity.StyleID);
			if (existingStyle == null)
				return false;

			_mapper.Map(entity, existingStyle);

			_unitOfWork.Style.Update(existingStyle);
			_unitOfWork.Save();

			return true;
		}
	}
}
