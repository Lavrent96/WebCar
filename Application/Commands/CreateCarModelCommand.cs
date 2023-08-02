using Application.Services.Interfaces;
using Azure.Core;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public sealed record CreateCarModelCommand(CarModel CarModel) : IRequest;

    public class CreateCarModelCommandHandler : IRequestHandler<CreateCarModelCommand>
    {
        private readonly ICarModelService _carService;
        public CreateCarModelCommandHandler(ICarModelService carService)
        {
            _carService = carService;
        }

        public async Task Handle(CreateCarModelCommand request, CancellationToken cancellationToken)
        {
            if (request.CarModel is not null)
            {
                await _carService.AddAsync(request.CarModel);
            }
        }
    }
}
