using Mango.Services.AuthAPI.Models.Dto;
using Mango.Services.AuthAPI.ServicesModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mango.Services.AuthAPI.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        protected ResponseDto _response;
        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }


        // POST api/<AuthAPIController>
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto model)
        {
            var errorMessege=await _authService.Register(model);
            if (!string.IsNullOrEmpty(errorMessege))
            {
                _response.IsSuccess = false;
                _response.Messege = errorMessege;
            }
                
            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            var loginResponse =await _authService.Login(model);
            if (loginResponse.User == null)
            {
                _response.IsSuccess = false;
                _response.Messege = "user or pass is incorrect ";
                return BadRequest(_response);
            }
            _response.Result = loginResponse;
            return  Ok(_response);
        }

        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDto model)
        {
            var assignRoleSucessful = await _authService.AssignRole(model.Email, model.Role.ToUpper());
            if (!assignRoleSucessful)
            {
                _response.IsSuccess = false;
              _response.Messege = "Error encounterd";

                return BadRequest(_response);
            }
            return Ok(_response);
        }
    }
}
