using Application.Services.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Commands
{
    public sealed record CreateTireCommand(Tire Tire) : IRequest;

    public class CreateTireCommandHandler : IRequestHandler<CreateTireCommand>
    {
        private readonly ITireService _tireService;
        public CreateTireCommandHandler(ITireService tireService)
        {
            _tireService = tireService;
        }

        public async Task Handle(CreateTireCommand request, CancellationToken cancellationToken)
        {
            if (request.Tire is not null)
            {
                await _tireService.AddAsync(request.Tire);
            }
        }
    }
}
