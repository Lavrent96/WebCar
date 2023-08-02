using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public sealed record GetAllTireTypeQuery : IRequest<List<TireType>>;

    public class GetAllTireTypeQueryHandler : IRequestHandler<GetAllTireTypeQuery, List<TireType>>
    {

        public GetAllTireTypeQueryHandler()
        {
        }

        public async Task<List<TireType>> Handle(GetAllTireTypeQuery request, CancellationToken cancellationToken)
        {
            return new List<TireType>()
            {
                TireType.RunFlat,
                TireType.Summer,
                TireType.Performance,
                TireType.EcoFriendly,
                TireType.AllSeason,
                TireType.AllTerrain,
                TireType.LowProfile,
                TireType.MudTerrain,
                TireType.Snow,
                TireType.OffRoad,
                TireType.Touring,
                TireType.Track,
                TireType.Winter
            };
        }
    }
}
