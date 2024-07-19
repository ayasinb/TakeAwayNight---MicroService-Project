﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Commands.AdressCommands;
using TakeAwayNight.Application.Features.CQRS.Commands.OrderDetailCommands;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public CreateOrderDetailCommandHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(CreateOrderDetailCommand createOrderDetailCommand)
        {
            await _repostory.CreateAsync(new OrderDetail
            {
                Amount = createOrderDetailCommand.Amount,
                OrderingId = createOrderDetailCommand.OrderingId,
                Price = createOrderDetailCommand.Price,
                ProductId = createOrderDetailCommand.ProductId,
                ProductName = createOrderDetailCommand.ProductName,
                TotalPrice = createOrderDetailCommand.TotalPrice
            });
        }
    }
}