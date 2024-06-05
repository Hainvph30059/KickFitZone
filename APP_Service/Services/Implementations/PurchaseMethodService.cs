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
	public class PurchaseMethodService : IPurcharMethodService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public PurchaseMethodService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(PurchaseMethodDto entity)
		{
			if (entity == null || _unitOfWork.PurchaseMethod.GetByID(entity.PurchaseMethodID) != null)
			{
				return false;
			}
			entity.PurchaseMethodID = Guid.NewGuid();
			_unitOfWork.PurchaseMethod.Create(_mapper.Map<PurchaseMethod>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var purchaseMethod = _unitOfWork.PurchaseMethod.GetByID(ID);
			if (purchaseMethod == null) { return false; }
			_unitOfWork.PurchaseMethod.Delete(purchaseMethod);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<PurchaseMethodDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<PurchaseMethodDto>();

			var purchaseMethod = _unitOfWork.PurchaseMethod.Find(c => c.Name.Contains(keyWord));
			if (purchaseMethod == null || !purchaseMethod.Any())
				return Enumerable.Empty<PurchaseMethodDto>();

			return _mapper.Map<IEnumerable<PurchaseMethodDto>>(purchaseMethod);
		}

		public async Task<IEnumerable<PurchaseMethodDto>> GetAllAsync(int? pageNumber, int? pagesize)
		{
			var lst = await _unitOfWork.PurchaseMethod.GetAllAsync();
			var purchaseMethodDto = _mapper.Map<IEnumerable<PurchaseMethodDto>>(lst);

			if (pageNumber.HasValue && pagesize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pagesize.Value;
				purchaseMethodDto = purchaseMethodDto.Skip(skipAmount).Take(pagesize.Value);
			}

			return purchaseMethodDto;
		}

		public PurchaseMethodDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var purchaseMethod = _unitOfWork.PurchaseMethod.GetByID(ID);
			if (purchaseMethod == null)
				return null;

			return _mapper.Map<PurchaseMethodDto>(purchaseMethod);
		}

		public bool Update(PurchaseMethodDto entity)
		{
			if (entity == null)
				return false;

			var existingPurchaseMethod = _unitOfWork.PurchaseMethod.GetByID(entity.PurchaseMethodID);
			if (existingPurchaseMethod == null)
				return false;

			_mapper.Map(entity, existingPurchaseMethod);

			_unitOfWork.PurchaseMethod.Update(existingPurchaseMethod);
			_unitOfWork.Save();

			return true;
		}
	}
}
