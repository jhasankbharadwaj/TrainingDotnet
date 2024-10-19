using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebappProject.Models;
using WebappProject.Services;

namespace WebappProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustController : ControllerBase
    {
        private readonly ICustomerService _CustomerService;
        public CustController(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cust = await _CustomerService.GetAllCustomer();

            return Ok(cust);
        }

        [HttpGet("{id}")]
        //[Route("{id}")] // /api/OurHero/:id
        public async Task<IActionResult> Get(int id)
        {
            var cust = await _CustomerService.GetCustomersByID(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddOrUpdateCustomer cust)
        {
            var customer = await _CustomerService.AddCustomer(cust);

            if (customer == null)
            {
                return BadRequest();
            }

            return Ok(new
            {
                message = " Created Successfully!!!",
                id = customer!.Id
            });
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] AddOrUpdateCustomer cust)
        {
            var customer= await _CustomerService.UpdateCustomer(id, cust);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Updated Successfully!!!",
                id = customer!.Id
            });
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!await _CustomerService.DeleteCustomerByID(id))
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Deleted Successfully!!!",
                id = id
            });
        }
    }
}
