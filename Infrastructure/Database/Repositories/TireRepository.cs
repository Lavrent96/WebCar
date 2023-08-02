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
    public class TireRepository : Repository<Tire>, ITireRepository
    {
        private readonly DbSet<Tire> _dbSet;

        public TireRepository(WebCarDbContext context) : base(context)
        {
            _dbSet = context.Set<Tire>();
        }

        public async Task<Tire> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
