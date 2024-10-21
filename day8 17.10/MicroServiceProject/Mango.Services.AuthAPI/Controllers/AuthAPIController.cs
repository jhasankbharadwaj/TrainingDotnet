using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mango.Services.AuthAPI.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        

        // POST api/<AuthAPIController>
        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> login()
        {
            return  Ok();
        }
    }
}
