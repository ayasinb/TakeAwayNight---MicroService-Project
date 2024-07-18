using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Commands.AdressCommands;
using TakeAwayNight.Application.Features.CQRS.Results.AdressResults;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.AdressHandlers
{
    public class GetAdressQueryHandler
    {
        private readonly IRepostory<Adress> _repostory;

        public GetAdressQueryHandler(IRepostory<Adress> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetAdressQueryResult>> Handle()
        {
           var values=await _repostory.GetAllAsync();
            return values.Select(x=>new GetAdressQueryResult
            {
                AdressId = x.AdressId,
                City = x.City,
                Name = x.Name,
                Detail  = x.Detail,
                District = x.District,
                UserId = x.UserId
            }).ToList();
        }
    }
}
