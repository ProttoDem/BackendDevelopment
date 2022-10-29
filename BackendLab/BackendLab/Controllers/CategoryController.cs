using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendLab.Controllers
{
    [Route("[controller]/[action]/{id?}")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateCategory([FromBody] Category category)
        {
            CategoryRepository categoryRepository = CategoryRepository.GetInstance();
            categoryRepository.AddNewCategory(category);
            return Ok($"Added new category: {category.Name}");
        }

        [HttpGet]
        public ActionResult<List<Category>> GetCategories()
        {
            CategoryRepository categoryRepository = CategoryRepository.GetInstance();            
            return Ok(categoryRepository.Categories());
        }

        [HttpGet]
        public ActionResult<Category> GetCategory([FromRoute]int id)
        {
            CategoryRepository categoryRepository = CategoryRepository.GetInstance();
            return Ok(categoryRepository.Category(id));
        }
    }
}
