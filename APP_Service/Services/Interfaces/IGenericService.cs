using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Services.Interfaces
{
    public interface IGenericService<T> where T : class
    {
		T GetByID(Guid ID);
		Task<IEnumerable<T>> GetAllAsync(int pageNumber, int pageSize);
		IEnumerable<T> Find(string keyWord);
		bool Create(T entity);
		bool Update(T entity);
		bool Delete(Guid ID);
	}
}
