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
    public sealed record GetAllCarBrandQuery : IRequest<List<CarBrand>>;

    public class GetAllCarBrandQueryHandler : IRequestHandler<GetAllCarBrandQuery, List<CarBrand>>
    {
        private readonly ICarBrandService _carBrandService;

        public GetAllCarBrandQueryHandler(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        public async Task<List<CarBrand>> Handle(GetAllCarBrandQuery request, CancellationToken cancellationToken)
        {
            return await _carBrandService.GetAllAsync();
        }
    }
}
