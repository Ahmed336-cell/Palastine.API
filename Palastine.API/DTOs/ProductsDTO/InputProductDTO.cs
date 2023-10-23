using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace Palastine.API.DTOs.Products
{
    public class InputProductDTO
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string CategoryID { get; set; }
    }
}
