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
    public class CarBrandRepository : Repository<CarBrand>, ICarBrandRepository
    {
        private readonly DbSet<CarBrand> _dbSet;

        public CarBrandRepository(WebCarDbContext context) : base(context)
        {
            _dbSet = context.Set<CarBrand>();
        }

        public async Task<CarBrand> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
