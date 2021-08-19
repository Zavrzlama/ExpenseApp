using System.Collections.Generic;
using ExpensesApp.Application.Contracts.Persistence;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExpensesApp.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly ExpensesAppDbContext _dbContext;

        public BaseRepository(ExpensesAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(T entitiy)
        {
            _dbContext.Set<T>().Remove(entitiy);
            await _dbContext.SaveChangesAsync();
        }
    }
}
