using Microsoft.AspNetCore.Mvc;
using ProductApi.Model;
using ProductApi.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
public CategoryController(ICategoryRepository categoryRepository) { 
            _categoryRepository = categoryRepository;
        } 

        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_categoryRepository.GetCategories());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id != null) {
                var Exist=_categoryRepository.GetCategoryByID(id);
                return new OkObjectResult(Exist);

            }
            return NotFound();
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public OkResult Delete(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return new OkResult();
        }
    }
}
