using AutoMapper;
using CasgemMicroservices.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroservices.Services.Catalog.Models;
using CasgemMicroservices.Services.Catalog.Settings;
using CasgemMicroservices.Shared.Dtos;
using MongoDB.Driver;

namespace CasgemMicroservices.Services.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            _mapper = mapper;
            var client=new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);

            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);

        }

        public async Task<Response<NoContent>> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var value=_mapper.Map<Category>(createCategoryDto);
            await _categoryCollection.InsertOneAsync(value);
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<NoContent>> DeleteCategoryAsync(string id)
        {
            var values = await _categoryCollection.DeleteOneAsync(x => x.CategoryID == id);
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<List<ResultCategoryDto>>> GetAllCategoryAsync()
        {
            var values = await _categoryCollection.Find(x => true).ToListAsync();
            return Response<List<ResultCategoryDto>>.Success(_mapper.Map<List<ResultCategoryDto>>(values), 200);
        }

        public async Task<Response<ResultCategoryDto>> GetByIdCategoryAsync(string id)
        {
            var values = await _categoryCollection.Find<Category>(x => x.CategoryID == id).FirstOrDefaultAsync();
            if (values == null) {

                return Response<ResultCategoryDto>.Fail("Kategori Bulunamadı", 404);
            }
            else
            {
                return Response<ResultCategoryDto>.Success(_mapper.Map<ResultCategoryDto>(values), 200);
            }
        }

        public async Task<Response<NoContent>> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            var values = _mapper.Map<Category>(updateCategoryDto);
            var result = await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryID == updateCategoryDto.CategoryID, values);
            if (result == null)
            {
                return Response<NoContent>.Fail("Kategori Bulunamadı", 404);
            }
            return Response<NoContent>.Success(204);
            
        }
    }
}
