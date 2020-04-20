using Ems.DbModelRepository;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EMS.SqlRepository.DbRepository
{
    public class EmsRepository<T> : IEmsRepository<T> where T : class
    {
        protected readonly EmsDbContext _dbContext;
        public EmsRepository(EmsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<T> Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> CountAll()
        {
            return await _dbContext.Set<T>().CountAsync();
        }

        public async Task<int> CountWhere(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).CountAsync();
        }

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IQueryable<T>> GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return await Task.Run(() => _dbContext.Set<T>().Where(predicate));
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task InsertBulk(List<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();

        }

        public async Task Remove(T entity)
        {
            await Task.Run(() => _dbContext.Set<T>().Remove(entity));
        }

        public async Task Update(T entity)
        {
            await Task.Run(() => _dbContext.Set<T>().Update(entity));
        }
    }
}
