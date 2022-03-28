using ApiTest.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiTest.Service.Interfaces
{
    public interface IClientService
    {
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<Client> CreateAsync(Client entity);

        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Expression<Func<Client, bool>> predicate);

        /// <param name="entity"></param>
        /// <returns></returns>
        Client UpdateAsync(Client entity);

        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<Client> GetAllAsync(Expression<Func<Client, bool>> predicate = null);

        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<Client> GetAsync(Expression<Func<Client, bool>> predicate);
    }
}
