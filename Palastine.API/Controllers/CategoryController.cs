﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Palastine.API.DTOs.CategoriesDTO;
using Palastine.API.DTOs.Products;
using Palastine.API.Interfaces;
using Palastine.API.Models;
using System.Text;
using System.Text.Json;

namespace Palastine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory(InputCategoryDTO Createcategory)
        {
            var result = await _categoryService.CreateCategory(Createcategory);
            if(result == null)
            {
                return NotFound("Can't Create a new Category");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
           var result = await _categoryService.GetCategoryById(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategorys()
        {
            var result = await _categoryService.GetAllCategorys();
            if (result == null)
                return NotFound();

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(string id)
        {
            return await _categoryService.DeleteById(id);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UpdateCategoryDTO input, string id)
        {
            var result = await _categoryService.Update(input, id);
            if (result == null)
                return NotFound("Cannot Update");

            return Ok(result);
        
        }
    }
}
