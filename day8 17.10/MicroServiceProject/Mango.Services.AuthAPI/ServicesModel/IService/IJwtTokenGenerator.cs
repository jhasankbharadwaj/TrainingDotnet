﻿using Mango.Services.AuthAPI.Models;

namespace Mango.Services.AuthAPI.ServicesModel.IService
{
    public interface IJwtTokenGenerator
    {
      string GenerateToken(ApplicationUser applicationUser);
    }
}
