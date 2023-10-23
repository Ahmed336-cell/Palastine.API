using Microsoft.AspNetCore.Mvc;
using Palastine.API.DTOs.Products;
using Palastine.API.Models;

namespace Palastine.API.Interfaces
{
    public interface IProductService
    {
        Task<Product> CreateProduct(InputProductDTO Createproduct);
        Task<Product> GetProductById(string id);
        Task<List<Product>> GetAllProducts();
        Task<IActionResult> DeleteById(string id);

        Task<Product> Update(UpdateProductDTO input, string id);

    }
}
