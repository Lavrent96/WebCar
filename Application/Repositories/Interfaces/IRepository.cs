using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> Add(TEntity obj);
        Task<List<TEntity>> GetAll();
        IQueryable<TEntity> GetFromDatabase();
        Task<TEntity> GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<bool> SaveChangesAsync();
        TEntity Find<T>(T primary);
        ValueTask<TEntity> FindAsync<T>(T primary);
    }
}
