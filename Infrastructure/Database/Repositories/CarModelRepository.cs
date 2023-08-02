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
    public class CarModelRepository : Repository<CarModel>, ICarModelRepository
    {
        private readonly DbSet<CarModel> _dbSet;

        public CarModelRepository(WebCarDbContext context) : base(context)
        {
            _dbSet = context.Set<CarModel>();
        }

        public async Task<CarModel> GetByIdAsync(int id)
        {
            return await _dbSet.Include(e=>e.Tires).FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
