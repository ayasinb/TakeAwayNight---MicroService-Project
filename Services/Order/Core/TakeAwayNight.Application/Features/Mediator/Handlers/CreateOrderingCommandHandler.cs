using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Commands.OrderDetailCommands;
using TakeAwayNight.Application.Features.Mediator.Commands;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.Mediator.Handlers
{
    public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommand>
    {
        private readonly IRepostory<Ordering> _repostory;

        public CreateOrderingCommandHandler(IRepostory<Ordering> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(CreateOrderingCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Ordering
            {
                TotalPrice = request.TotalPrice,
                OrderDate = request.OrderDate,
                UserId = request.UserId
            });
        }
    }
}
