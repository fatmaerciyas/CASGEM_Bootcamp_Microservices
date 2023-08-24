
using CasgemMicroservices.Services.Order.Core.Application.Dtos.AdsressDtos;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDetailsDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetAllAddressQueryRequest : IRequest<List<ResultAddressDto>>
    {
    }
}
