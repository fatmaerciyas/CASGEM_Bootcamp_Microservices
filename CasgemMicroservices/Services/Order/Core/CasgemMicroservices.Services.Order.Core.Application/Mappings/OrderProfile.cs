using AutoMapper;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDtos;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Mappings
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<ResultOrderingDto, Domain.Entities.Ordering>().ReverseMap();
            CreateMap<CreateOrderDto, Domain.Entities.Ordering>().ReverseMap();
            CreateMap<UpdateOrderDto, Domain.Entities.Ordering>().ReverseMap();
        }
    }
}
