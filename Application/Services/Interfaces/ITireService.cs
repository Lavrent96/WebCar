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
        Task<Tire> GetByIdAsync(int id);
        Task<List<Tire>> GetAllAsync();
        Task<List<Tire>> GetAsync();
        Task<Tire> AddAsync(Tire tire);
        Task<Tire> UpdateAsync(int id, Tire tire);
    }
}
