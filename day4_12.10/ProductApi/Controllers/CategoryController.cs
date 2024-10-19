using Microsoft.AspNetCore.Mvc;
using ProductApi.Model;
using ProductApi.Repository;
using System.Transactions;

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
        public IActionResult Post([FromBody] Category category)
        {
            try
            {
                _categoryRepository.InsertCategory(category);
                return Ok();
            }
            catch (Exception )
            {
                return BadRequest();
            }

        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    _categoryRepository.UpdateCategory(category);
                    scope.Complete();
                }
                return new NoContentResult();
            }
            catch (Exception) {
                return NotFound();

            }
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _categoryRepository.DeleteCategory(id);
                return new OkResult();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
