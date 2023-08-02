using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ICarBrandService
    {
        Task<CarBrand> GetByIdAsync(int id);
        Task<List<CarBrand>> GetAllAsync();
        Task<List<CarBrand>> GetAsync();
        Task<CarBrand> AddAsync(CarBrand carBrand);
        Task<CarBrand> UpdateAsync(int id, CarBrand carBrand);
    }
}
