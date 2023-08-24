using AutoMapper;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.AdsressDtos;
using CasgemMicroservices.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Mappings
{
    public class AddressProfile:Profile
    {
        public AddressProfile()
        {
            CreateMap<ResultAddressDto, Addresss>().ReverseMap();
            CreateMap<CreateAddressDto, Addresss>().ReverseMap();
            CreateMap<UpdateAddressDto, Addresss>().ReverseMap();
        }
    }
}
