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
    public class UpdateOrderDetailCommandHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public UpdateOrderDetailCommandHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(UpdateOrderDetailCommand updateOrderDetailCommand)
        {
            var values=await _repostory.GetByIdAsync(updateOrderDetailCommand.OrderDetailId);
            values.Price = updateOrderDetailCommand.Price;
            values.OrderingId = updateOrderDetailCommand.OrderingId;
            values.ProductName = updateOrderDetailCommand.ProductName;
            values.Amount = updateOrderDetailCommand.Amount;
            values.TotalPrice = updateOrderDetailCommand.TotalPrice;
            values.ProductId = updateOrderDetailCommand.ProductId;
            await _repostory.UpdateAsync(values);
        }
    }
}
