using APP_DATA.ClassDTO;
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
	public class ProductService : IProductService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public bool Create(ProductDto entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(Guid ID)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ProductDto> Find(string keyWord)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<ProductDto>> GetAllAsync(int pageNumber, int pageSize)
		{
			try
			{
				int skipAmount = (pageNumber - 1) * pageSize;
				var lst = await _unitOfWork.Product.GetAllAsync();
				var addressDto = _mapper.Map<IEnumerable<ProductDto>>(lst);
				var result = addressDto.Skip(skipAmount).Take(pageSize);
				return result;
			}
			catch (Exception ex)
			{
				throw new Exception("Error: " + ex);
			}
		}

		public ProductDto GetByID(Guid ID)
		{
			throw new NotImplementedException();
		}

		public bool Update(ProductDto entity)
		{
			throw new NotImplementedException();
		}
	}
}
