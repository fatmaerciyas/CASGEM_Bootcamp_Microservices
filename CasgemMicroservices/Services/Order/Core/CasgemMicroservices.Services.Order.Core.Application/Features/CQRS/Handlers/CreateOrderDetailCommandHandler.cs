using CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Commands;
using CasgemMicroservices.Services.Order.Core.Application.Interfaceses;
using CasgemMicroservices.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommandRequest>
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public Task Handle(CreateOrderDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new OrderDetail
            {
                ProductID=request.ProductID,
                ProductName=request.ProductName,
                ProductPrice=request.ProductPrice,
                ProductAmount=request.ProductAmount,
                OrderingID=request.OrderingID,
            };
            return _repository.CreateAsync(values);
        }
    }
}
