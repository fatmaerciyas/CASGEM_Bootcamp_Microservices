using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDetailsDtos;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdOrderDetailQueryRequest : IRequest<ResultOrderDetailDto>
    {
        public GetByIdOrderDetailQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
