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
    public class CarBrandService : ICarBrandService
    {
        private readonly ICarBrandRepository _carBrandRepository;

        public CarBrandService(ICarBrandRepository carBrandRepository)
        {
            _carBrandRepository = carBrandRepository;
        }

        public async Task<CarBrand> AddAsync(CarBrand carBrand)
        {
            var result = await _carBrandRepository.Add(carBrand);
            await _carBrandRepository.SaveChangesAsync();
            return result;

        }

        public async Task<List<CarBrand>> GetAllAsync()
        {
            var result = await _carBrandRepository.GetAll();
            if (result is not null && result.Count>0)
                return result;

            return new List<CarBrand>();
        }

        public async Task<List<CarBrand>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CarBrand> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CarBrand> UpdateAsync(int id, CarBrand carBrand)
        {
            throw new NotImplementedException();
        }
    }
}
