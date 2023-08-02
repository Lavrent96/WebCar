using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ITireService
    {
        Task<TireSize> GetByIdAsync(int id);
        Task<List<TireSize>> GetAllAsync();
        Task<List<TireSize>> GetAsync();
        Task<TireSize> AddAsync(TireSize tire);
        Task<TireSize> UpdateAsync(int id, TireSize tire);
    }
}
