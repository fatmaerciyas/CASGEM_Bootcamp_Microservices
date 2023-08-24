using CasgemMicroservices.Services.Basket.Dtos;
using CasgemMicroservices.Shared.Dtos;

namespace CasgemMicroservices.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>>GetBasket(string userID);
        Task<Response<bool>>SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>>DeleteBasket(string userID);
    }
}
