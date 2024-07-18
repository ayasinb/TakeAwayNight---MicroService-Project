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
    public class UpdateAdressCommandHandler
    {
        private readonly IRepostory<Adress> _repostory;

        public UpdateAdressCommandHandler(IRepostory<Adress> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(UpdateAdressCommand updateAdressCommand)
        {
            var values=await _repostory.GetByIdAsync(updateAdressCommand.AdressId);
            values.Detail = updateAdressCommand.Detail;
            values.City = updateAdressCommand.City;
            values.District = updateAdressCommand.District;
            values.UserId = updateAdressCommand.UserId;
            values.Name = updateAdressCommand.Name;
            await _repostory.UpdateAsync(values);
        }
    }
}
