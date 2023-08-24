using CasgemMicroservices.Services.Discount.Dtos;
using CasgemMicroservices.Services.Discount.Models;
using CasgemMicroservices.Shared.Dtos;

namespace CasgemMicroservices.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<ResultDiscountDto>>>GetAllDiscountCouponAsync();
        Task<Response<ResultDiscountDto>> GetByIdDiscountCouponAsync(int id);
        Task<Response<NoContent>> CreateDiscountCouponAsync(CreateDiscountDto createdDiscountDto);
        Task<Response<NoContent>> UpdateDiscountCouponAsync(UpdateDiscountDto updateDiscountDto);
        Task<Response<NoContent>> DeleteDiscountCouponAsync(int id);


    }
}
