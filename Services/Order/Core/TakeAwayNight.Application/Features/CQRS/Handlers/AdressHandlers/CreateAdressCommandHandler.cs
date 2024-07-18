using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Commands.AdressCommands;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.AdressHandlers
{
    public class CreateAdressCommandHandler
    {
        private readonly IRepostory<Adress> _repostory;

        public CreateAdressCommandHandler(IRepostory<Adress> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(CreateAdressCommand createAdressCommand)
        {
            await _repostory.CreateAsync(new Adress
            {
                City = createAdressCommand.City,
                Detail = createAdressCommand.Detail,
                District = createAdressCommand.District,
                Name = createAdressCommand.Name,
                UserId = createAdressCommand.UserId,
            });
        }
    }
}
