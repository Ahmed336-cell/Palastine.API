using Firebase.Database;
using Microsoft.AspNetCore.Mvc;
using Palastine.API.DTOs.CategoriesDTO;
using Palastine.API.Models;

namespace Palastine.API.Interfaces
{
    public interface ICategoryService
    {
        Task<Category> CreateCategory(InputCategoryDTO Createcategory);
        Task<List<Category>> GetAllCategorys();
        Task<Category> GetCategoryById(string id);
        Task<IActionResult> DeleteById(string id);
        Task<Category> Update(UpdateCategoryDTO input, string id);
    }
}
