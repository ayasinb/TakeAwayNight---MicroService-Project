using TakeAwayNight.Catalog.Dtos.CategoryDtos;

namespace TakeAwayNight.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createcategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updatecategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
    }
}
