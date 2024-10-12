using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebappProject.Models;
using WebappProject.Services;

namespace WebappProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _CustomerService;

        public CustomerController(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] bool? isActive = null)
        {
            return Ok(_CustomerService.GetAllCustomer());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var hero = _CustomerService.GetCustomersByID(id);
            if (hero == null)
            {
                return NotFound();
            }
            return Ok(hero);
        }

        [HttpPost]
        public IActionResult Post(AddOrUpdateCustomer CustomerObject)
        {
            var hero = _CustomerService.AddCustomer(CustomerObject);

            if (hero == null)
            {
                return BadRequest();
            }

            return Ok(new
            {
                message = "Super Hero Created Successfully!!!",
                id = hero!.Id
            });
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] AddOrUpdateCustomer heroObject)
        {
            var customer = _CustomerService.UpdateCustomer(id, heroObject);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "customer Updated Successfully!!!",
                id = customer!.Id
            });
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            if (!_CustomerService.DeleteCustomerByID(id))
            {
                return NotFound();
            }

            return Ok(new
            {
                message = " Deleted Successfully!!!",
                id = id
            });
        }
    }
}
