using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Repositories.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		T GetByID(Guid id);
		Task<IEnumerable<T>> GetAllAsync();
		IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
		void Create(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
