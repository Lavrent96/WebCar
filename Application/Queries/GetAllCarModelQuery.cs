using Application.Services.Implementations;
using Application.Services.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public sealed record GetAllCarModelQuery : IRequest<List<CarModel>>;

    public class GetAllCarModelQueryHandler : IRequestHandler<GetAllCarModelQuery, List<CarModel>>
    {
        private readonly ICarModelService _carModelService;

        public GetAllCarModelQueryHandler(ICarModelService carModelService)
        {
            _carModelService = carModelService;
        }

        public async Task<List<CarModel>> Handle(GetAllCarModelQuery request, CancellationToken cancellationToken)
        {
            return await _carModelService.GetAllAsync();
        }
    }
}
