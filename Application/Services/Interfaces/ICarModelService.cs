using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ICarModelService
    {
        Task<CarModel> GetByIdAsync(int id);
        Task<List<CarModel>> GetAllAsync();
        Task<List<CarModel>> GetAllByBrandIdAsync(int carBrandId);
        Task<List<CarModel>> GetAsync();
        Task<CarModel> AddAsync(CarModel carModel);
        Task<CarModel> UpdateAsync(int id, CarModel carModel);
    }
}
