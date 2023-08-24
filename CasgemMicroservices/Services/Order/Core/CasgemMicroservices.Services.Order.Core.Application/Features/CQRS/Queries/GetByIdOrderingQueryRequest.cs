using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdOrderingQueryRequest : IRequest<ResultOrderingDto>
    {
        public GetByIdOrderingQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
