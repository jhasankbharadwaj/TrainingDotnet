using Mango.Services.AuthAPI.Models;

namespace Mango.Services.AuthAPI.ServicesModel.IService
{
    public interface IJwtToken
    {
        public string GenerateToken(ApplicationUser applicationUser);
    }
}
