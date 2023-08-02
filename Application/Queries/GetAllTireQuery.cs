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
    public sealed record GetAllTireQuery : IRequest<List<Tire>>;

    public class GetAllTireQueryHandler : IRequestHandler<GetAllTireQuery, List<Tire>>
    {
        private readonly ITireService _tireService;

        public GetAllTireQueryHandler(ITireService tireService)
        {
            _tireService = tireService;
        }

        public async Task<List<Tire>> Handle(GetAllTireQuery request, CancellationToken cancellationToken)
        {
            return await _tireService.GetAllAsync();
        }
    }
}
