using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiTest.Data.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> CreateAsync(T entity);

        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> DeleteAsync(Expression<Func<T, bool>> predicate);

        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity);

        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);

        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
    }
}
