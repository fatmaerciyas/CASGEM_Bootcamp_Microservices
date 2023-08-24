using CasgemMicroservices.Services.Order.Core.Application.Dtos.AdsressDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdAddressQueryRequest : IRequest<ResultAddressDto>
    {
        public int Id { get; set; }

        public GetByIdAddressQueryRequest(int id)
        {
            Id = id;
        }
    }
}
