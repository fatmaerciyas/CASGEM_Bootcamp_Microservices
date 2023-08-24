using CasgemMicroservices.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroservices.Services.Catalog.Dtos.ProductDtos;
using CasgemMicroservices.Shared.Dtos;

namespace CasgemMicroservices.Services.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetAllProductAsync();
        Task<Response<ResultProductDto>> GetByIdProductAsync(string id);

        Task<Response<NoContent>> CreateProductAsync(CreateProductDto createProductDto);
        Task<Response<NoContent>> UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<Response<NoContent>> DeleteProductAsync(string id);
    }
}
