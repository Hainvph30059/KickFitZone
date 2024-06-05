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
			if (entity == null || _unitOfWork.Product.GetByID(entity.ProductID) != null)
			{
				return false;
			}
			entity.ProductID = Guid.NewGuid();
			_unitOfWork.Product.Create(_mapper.Map<Product>(entity));
			_unitOfWork.Save();
			return true;
		}

		public bool Delete(Guid ID)
		{
			if (ID == Guid.Empty) { return false; }
			var product = _unitOfWork.Product.GetByID(ID);
			if (product == null) { return false; }
			_unitOfWork.Product.Delete(product);
			_unitOfWork.Save();
			return true;
		}

		public IEnumerable<ProductDto> Find(string keyWord)
		{
			if (string.IsNullOrEmpty(keyWord))
				return Enumerable.Empty<ProductDto>();

			var product = _unitOfWork.Product.Find(c => c.Name.Contains(keyWord));
			if (product == null || !product.Any())
				return Enumerable.Empty<ProductDto>();

			return _mapper.Map<IEnumerable<ProductDto>>(product);
		}

		public async Task<IEnumerable<ProductDto>> GetAllAsync(int? pageNumber, int? pageSize)
		{
			var lst = await _unitOfWork.Product.GetAllAsync();
			var productDto = _mapper.Map<IEnumerable<ProductDto>>(lst);

			if (pageNumber.HasValue && pageSize.HasValue)
			{
				int skipAmount = (pageNumber.Value - 1) * pageSize.Value;
				productDto = productDto.Skip(skipAmount).Take(pageSize.Value);
			}

			return productDto;
		}

		public ProductDto GetByID(Guid ID)
		{
			if (ID == Guid.Empty)
				throw new ArgumentException("The provided ID is not valid.", nameof(ID));

			var product = _unitOfWork.Product.GetByID(ID);
			if (product == null)
				return null;

			return _mapper.Map<ProductDto>(product);
		}

		public bool Update(ProductDto entity)
		{
			if (entity == null)
				return false;

			var existingProduct = _unitOfWork.Product.GetByID(entity.ProductID);
			if (existingProduct == null)
				return false;

			_mapper.Map(entity, existingProduct);

			_unitOfWork.Product.Update(existingProduct);
			_unitOfWork.Save();

			return true;
		}
	}
}
