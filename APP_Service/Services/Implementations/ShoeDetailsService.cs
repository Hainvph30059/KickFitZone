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
	public class ShoeDetailsService : IShoeDetailsService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public ShoeDetailsService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(ShoesDetailsDto entity)
		{
			if (entity == null || _unitOfWork.ShoesDetail.GetByID(entity.ShoesDetailsID) != null)
			{
				return false;
			}
			if (_unitOfWork.Size.GetByID(entity.SizeID) == null) return false;
			if (_unitOfWork.Color.GetByID(entity.ColorID) == null) return false;
			if (_unitOfWork.Material.GetByID(entity.MaterialID) == null) return false;
			if (_unitOfWork.Image.GetByID(entity.ImageID) == null) return false;
			if (_unitOfWork.Style.GetByID(entity.StyleID) == null) return false;
			if (_unitOfWork.Product.GetByID(entity.ProductID) == null) return false;
			if (_unitOfWork.Sex.GetByID(entity.SexID) == null) return false;
			
			entity.ShoesDetailsID = Guid.NewGuid();
			_unitOfWork.ShoesDetail.Create(_mapper.Map<ShoesDetails>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var shoesDetail = _unitOfWork.ShoesDetail.GetByID(ID);
			if (shoesDetail == null) { return false; }
			_unitOfWork.ShoesDetail.Delete(shoesDetail);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<ShoesDetailsDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<ShoesDetailsDto>();

			var shoesDetail = _unitOfWork.ShoesDetail.Find(c => c.ShoesDetailsCode.Contains(keyWord));
			if (shoesDetail == null || !shoesDetail.Any())
				return Enumerable.Empty<ShoesDetailsDto>();

			return _mapper.Map<IEnumerable<ShoesDetailsDto>>(shoesDetail);
		}

		public async Task<IEnumerable<ShoesDetailsDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.ShoesDetail.GetAllAsync();
			var shoesDetailsDto = _mapper.Map<IEnumerable<ShoesDetailsDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				shoesDetailsDto = shoesDetailsDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return shoesDetailsDto;
		}

		public ShoesDetailsDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var shoesDetail = _unitOfWork.ShoesDetail.GetByID(ID);
			if (shoesDetail == null)
				return null;

			return _mapper.Map<ShoesDetailsDto>(shoesDetail);
		}

		public bool Update(ShoesDetailsDto entity)
		{
			if (entity == null)
				return false;

			var existingShoesDetail = _unitOfWork.ShoesDetail.GetByID(entity.ShoesDetailsID);
			if (existingShoesDetail == null)
				return false;
			if (_unitOfWork.Size.GetByID(entity.SizeID) == null) return false;
			if (_unitOfWork.Color.GetByID(entity.ColorID) == null) return false;
			if (_unitOfWork.Material.GetByID(entity.MaterialID) == null) return false;
			if (_unitOfWork.Image.GetByID(entity.ImageID) == null) return false;
			if (_unitOfWork.Style.GetByID(entity.StyleID) == null) return false;
			if (_unitOfWork.Product.GetByID(entity.ProductID) == null) return false;
			if (_unitOfWork.Sex.GetByID(entity.SexID) == null) return false;
			_mapper.Map(entity, existingShoesDetail);

			_unitOfWork.ShoesDetail.Update(existingShoesDetail);
			_unitOfWork.Save();

			return true;
		}
	}
}
