using CasgemMicroservices.Services.Order.Core.Application.Dtos.AdsressDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Commands
{
    public class CreateAddressCommandRequest:IRequest
    {
        public string UserID { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
}
