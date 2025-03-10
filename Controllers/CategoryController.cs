using BudgetSheetApi.Models;
using BudgetSheetApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetSheetApi.Controllers
{
    [Route("api/Categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryModel>>> GetCategories()
        {
            var categories = await _categoryService.GetCategories();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryModel>> CreateCategory([FromBody] NewCategory newCategory)
        {
            var category = await _categoryService.CreateCategory(newCategory);
            return Ok(category);
        }
    }
}