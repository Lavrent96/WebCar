using Application.Repositories.Interfaces;
using Application.Services.Interfaces;
using Domain.Entities;

namespace Application.Services.Implementations
{
    public class TireService : ITireService
    {
        private readonly ITireRepository _tireRepository;

        public TireService(ITireRepository tireRepository)
        {
            _tireRepository = tireRepository;
        }

        public async Task<Tire> AddAsync(Tire tire)
        {
            return await _tireRepository.Add(tire);
        }

        public async Task<List<Tire>> GetAllAsync()
        {
            return await _tireRepository.GetAll();
        }

        public async Task<List<Tire>> GetAsync()
        {
            return await _tireRepository.GetAll();
        }

        public async Task<Tire> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Tire> UpdateAsync(int id, Tire tire)
        {
            throw new NotImplementedException();
        }
    }
}
