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

        public async Task<TireSize> AddAsync(TireSize tire)
        {
            return await _tireRepository.Add(tire);
        }

        public async Task<List<TireSize>> GetAllAsync()
        {
            return await _tireRepository.GetAll();
        }

        public async Task<List<TireSize>> GetAsync()
        {
            return await _tireRepository.GetAll();
        }

        public async Task<TireSize> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<TireSize> UpdateAsync(int id, TireSize tire)
        {
            throw new NotImplementedException();
        }
    }
}
