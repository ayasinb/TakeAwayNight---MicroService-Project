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
    public class RemoveAdressCommandHandler
    {
        private readonly IRepostory<Adress> _repostory;

        public RemoveAdressCommandHandler(IRepostory<Adress> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(RemoveAdressCommand removeAdressCommand)
        {
           await _repostory.DeleteAsync(removeAdressCommand.Id);
        }
    }
}
