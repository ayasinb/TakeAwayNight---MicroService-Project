using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Commands.OrderDetailCommands;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class RemoveOrderDetailCommandHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public RemoveOrderDetailCommandHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(RemoveOrderDetailCommand removeOrderDetailCommand)
        {
            await _repostory.DeleteAsync(removeOrderDetailCommand.Id);
        }
    }
}
