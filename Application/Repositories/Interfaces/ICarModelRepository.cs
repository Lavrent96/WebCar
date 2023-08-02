using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Interfaces
{
    public interface ICarModelRepository : IRepository<CarModel>
    {
        Task<CarModel> GetByIdAsync(int id);
        Task<List<CarModel>> GetByBrandIdAsync(int brandId);
    }
}
