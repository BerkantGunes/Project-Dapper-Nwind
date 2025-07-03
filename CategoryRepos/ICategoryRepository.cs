using Project5_DapperNorthwind.DTOs.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.Repos.CategoryRepos
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(int id); // id ye göre silme işlemi yapacağız.
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id); // burada da adı üstünde id sine göre işlem yaparız.
    }
}
