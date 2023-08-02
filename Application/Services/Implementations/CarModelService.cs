using Application.Repositories.Interfaces;
using Application.Services.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class CarModelService : ICarModelService
    {
        private readonly ICarModelRepository _carModelRepository;

        public CarModelService(ICarModelRepository carModelRepository)
        {
            _carModelRepository = carModelRepository;
        }

        public async Task<CarModel> AddAsync(CarModel carModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarModel>> GetAllAsync()
        {
            return await _carModelRepository.GetAll();
        }

        public async Task<List<CarModel>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CarModel> GetByIdAsync(int id)
        {
            return await _carModelRepository.GetByIdAsync(id);
        }

        public async Task<CarModel> UpdateAsync(int id, CarModel carModel)
        {
            throw new NotImplementedException();
        }
    }
}
