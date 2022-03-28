using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApiTest.Data.Contexts;
using ApiTest.Data.IRepositories;
using ApiTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ApiTest.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal MarketDbContext dbContext;
        internal DbSet<T> dbSet;
        public GenericRepository(MarketDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            var entry = await dbSet.AddAsync(entity);

            await dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public Task<T> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
