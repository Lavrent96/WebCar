using Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity obj)
        {
            var result = await _dbSet.AddAsync(obj);
            return result.Entity;
        }

        public async Task Update(TEntity obj)
        {
            _dbSet.Update(obj);
        }

        public async Task Delete(object id)
        {
            TEntity existing = await _dbSet.FindAsync(id);
            _dbSet.Remove(existing);
        }

        public TEntity Find<T>(T primary)
        {
            return _dbSet.Find(primary);
        }

        public ValueTask<TEntity> FindAsync<T>(T primary)
        {
            return _dbSet.FindAsync(primary);
        }

        public async Task<TEntity> GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetFromDatabase().FirstOrDefaultAsync(predicate);
        }

        public async Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetFromDatabase().ToListAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await GetFromDatabase().ToListAsync();
        }

        public virtual IQueryable<TEntity> GetFromDatabase()
        {
            return _dbSet.AsNoTracking();
        }

        public async Task<bool> SaveChangesAsync()
        {
            int resp = await _context.SaveChangesAsync();
            return resp > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }

}
