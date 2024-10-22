using Mango.Services.AuthAPI.Data;
using Mango.Services.AuthAPI.Models;
using Mango.Services.AuthAPI.Models.Dto;
using Mango.Services.AuthAPI.ServicesModel;
using Mango.Services.AuthAPI.ServicesModel.IService;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;


namespace Mango.Services.AuthAPI.ServicesModel
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        protected readonly IJwtToken _jwtToken;


        public AuthService(AppDbContext db, UserManager<ApplicationUser> userManager,IJwtToken jwtToken)
        {
            _db = db;
            _userManager = userManager;
            _jwtToken = jwtToken;
        }

        public AppDbContext Db => _db;

        public UserManager<ApplicationUser> UserManager => _userManager;

        



        

        public async Task<string> Register(RegistrationRequestDto registrationRequestDto)
        {
            ApplicationUser user = new()
            {
                UserName = registrationRequestDto.Email,
                Email = registrationRequestDto.Email,
                NormalizedEmail = registrationRequestDto.Email.ToLower(),
                Name = registrationRequestDto.Name,
                PhoneNumber = registrationRequestDto.PhoneNumber,
            };
            try
            {
                var result = await UserManager.CreateAsync(user,registrationRequestDto.Password);
                if (result.Succeeded)
                {
                    var userToReturn = Db.ApplicationUsers.First(u => u.UserName == registrationRequestDto.Email);

                    UserDto userDto = new()
                    {
                        Email = userToReturn.Email,
                        Id = userToReturn.Id,
                        Name = userToReturn.Name,
                        Phonenumber = userToReturn.PhoneNumber,
                    };
                    return "";
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }
            catch (Exception ex)
            {
            }
            return "Eroor Encounter";

        }

       public  async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            var user= Db.ApplicationUsers.FirstOrDefault(u=>u.UserName.ToLower()==loginRequestDto.UserName.ToLower());
            bool isValid =await UserManager.CheckPasswordAsync(user, loginRequestDto.Password);
            if(user ==null || isValid == false)
            {
                return new LoginResponseDto()
                {
                    User = null,
                    Token = " "

                };

            }
            //
            var token = _jwtToken.GenerateToken(user);
            UserDto userDto = new()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                Phonenumber = user.PhoneNumber,

            };
            LoginResponseDto loginResponseDto = new LoginResponseDto()
            {
                User = userDto,
                Token = token,
            };
            return loginResponseDto;
        }
    }
}