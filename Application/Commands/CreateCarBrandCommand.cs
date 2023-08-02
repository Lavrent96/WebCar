using Application.Services.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public sealed record CreateCarBrandCommand(CarBrand CarBrand) : IRequest;

    public class CreateCarBrandCommandHandler : IRequestHandler<CreateCarBrandCommand>
    {
        private readonly ICarBrandService _carBrandService;
        public CreateCarBrandCommandHandler(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        public async Task Handle(CreateCarBrandCommand request, CancellationToken cancellationToken)
        {
            if (request.CarBrand is not null)
            {
                await _carBrandService.AddAsync(request.CarBrand);
            }
        }
    }
}
