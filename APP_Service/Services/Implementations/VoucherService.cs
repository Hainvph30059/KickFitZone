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
	public class VoucherService : IVoucherService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public VoucherService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(VouchersDto entity)
		{
			if (entity == null || _unitOfWork.Voucher.GetByID(entity.VoucherID) != null)
			{
				return false;
			}
			entity.VoucherID = Guid.NewGuid();
			_unitOfWork.Voucher.Create(_mapper.Map<Voucher>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var voucher = _unitOfWork.Voucher.GetByID(ID);
			if (voucher == null) { return false; }
			_unitOfWork.Voucher.Delete(voucher);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<VouchersDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<VouchersDto>();

			var voucher = _unitOfWork.Voucher.Find(c => c.VoucherCode.Contains(keyWord));
			if (voucher == null || !voucher.Any())
				return Enumerable.Empty<VouchersDto>();

			return _mapper.Map<IEnumerable<VouchersDto>>(voucher);
		}

		public async Task<IEnumerable<VouchersDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Voucher.GetAllAsync();
			var vouchersDto = _mapper.Map<IEnumerable<VouchersDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				vouchersDto = vouchersDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return vouchersDto;
		}

		public VouchersDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var voucher = _unitOfWork.Voucher.GetByID(ID);
			if (voucher == null)
				return null;

			return _mapper.Map<VouchersDto>(voucher);
		}

		public bool Update(VouchersDto entity)
		{
			if (entity == null)
				return false;

			var existingVoucher = _unitOfWork.Voucher.GetByID(entity.VoucherID);
			if (existingVoucher == null)
				return false;

			_mapper.Map(entity, existingVoucher);

			_unitOfWork.Voucher.Update(existingVoucher);
			_unitOfWork.Save();

			return true;
		}
	}
}
