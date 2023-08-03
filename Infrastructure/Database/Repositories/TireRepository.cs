using Application.Repositories.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Repositories
{
    public class TireRepository : Repository<TireSize>, ITireRepository
    {
        private readonly DbSet<TireSize> _dbSet;

        public TireRepository(WebCarDbContext context) : base(context)
        {
            _dbSet = context.Set<TireSize>();
        }

        public async Task<List<TireSize>> GetByCarModelIdAsync(int carModelId)
        {
            return await _dbSet.Where(e => e.CarModelId == carModelId).ToListAsync();
        }

        public async Task<TireSize> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
