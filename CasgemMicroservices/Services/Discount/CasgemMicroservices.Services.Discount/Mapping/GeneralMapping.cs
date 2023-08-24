using AutoMapper;
using CasgemMicroservices.Services.Discount.Dtos;
using CasgemMicroservices.Services.Discount.Models;

namespace CasgemMicroservices.Services.Discount.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<DiscountCoupons ,ResultDiscountDto>().ReverseMap();
            CreateMap<DiscountCoupons ,CreateDiscountDto>().ReverseMap();
            CreateMap<DiscountCoupons ,UpdateDiscountDto>().ReverseMap();
        }
    }
}
