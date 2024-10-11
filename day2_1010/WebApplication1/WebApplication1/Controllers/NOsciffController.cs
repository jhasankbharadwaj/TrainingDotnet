using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{  //defining the uri in the requirement accoring to the output end point . 
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NOsciffController : ControllerBase
    {
        //we can write the Get, post put ,patch methods can be writtern
        [HttpGet]
        public string Gethello()
        {
            return "hello world ";

        }
        [HttpGet]
        public int GetMore()
        {
            return 90;
        }
    }
}
