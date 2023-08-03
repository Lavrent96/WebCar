using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Interfaces
{
    public interface ITireRepository : IRepository<TireSize>
    {
        Task<TireSize> GetByIdAsync(int id);
        Task<List<TireSize>> GetByCarModelIdAsync(int carModelId);
    }
}
