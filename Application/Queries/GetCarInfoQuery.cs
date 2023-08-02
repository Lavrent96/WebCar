using Application.Services.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Queries
{
    public sealed record GetCarInfoQuery : IRequest<CarModel>
    {
        public int CarModelId { get; set; }
    }

    public class GetCarInfoQueryHanlder : IRequestHandler<GetCarInfoQuery, CarModel>
    {
        private readonly ICarModelService _carModelService;

        public GetCarInfoQueryHanlder(ICarModelService carModelService)
        {
            _carModelService=carModelService;
        }

        public async Task<CarModel> Handle(GetCarInfoQuery request, CancellationToken cancellationToken)
        {
            if (request.CarModelId >0)
            {
                var carModel = await _carModelService.GetByIdAsync(request.CarModelId);
                if (carModel != null)
                    return carModel;
            }

            return new CarModel();
        }
    }
}
