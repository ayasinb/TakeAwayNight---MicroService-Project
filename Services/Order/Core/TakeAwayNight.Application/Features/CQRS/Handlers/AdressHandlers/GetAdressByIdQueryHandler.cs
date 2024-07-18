using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Commands.AdressCommands;
using TakeAwayNight.Application.Features.CQRS.Queries.AdressQueries;
using TakeAwayNight.Application.Features.CQRS.Results.AdressResults;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.AdressHandlers
{
    public class GetAdressByIdQueryHandler
    {
        private readonly IRepostory<Adress> _repostory;

        public GetAdressByIdQueryHandler(IRepostory<Adress> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetAdressByIdQueryResult> Handle(GetAdressByIdQuery query)
        {
            var values=await _repostory.GetByIdAsync(query.Id);
            return new GetAdressByIdQueryResult
            {
                AdressId = values.AdressId,
                City = values.City,
                Detail = values.Detail,
                District = values.District,
                Name = values.Name,
                UserId = values.UserId
            };
        }
    }
}
