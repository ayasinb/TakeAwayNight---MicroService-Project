using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayNight.Application.Features.CQRS.Results.OrderDetailResults;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Domain.Entities;

namespace TakeAwayNight.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public GetOrderDetailQueryHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var values=await _repostory.GetAllAsync();
            return values.Select(x=>new GetOrderDetailQueryResult
            {
                Amount = x.Amount,
                OrderDetailId = x.OrderDetailId,
                OrderingId = x.OrderingId,
                Price = x.Price,
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                TotalPrice = x.TotalPrice,
            }).ToList();
        }
    }
}
