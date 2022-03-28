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

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var result = await dbSet.FirstOrDefaultAsync(predicate);

            if (result != null)
                return false;

            dbSet.Remove(result);

            await dbContext.SaveChangesAsync();

            return true;
        }

        public IQueryable<T> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is null ? dbSet : dbSet.Where(predicate); 
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public T UpdateAsync(T entity)
        {
            var entry = dbSet.Update(entity);

            return entry.Entity;
        }
    }
}
