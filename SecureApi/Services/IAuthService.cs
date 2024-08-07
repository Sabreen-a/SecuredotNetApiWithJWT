﻿using SecureApi.Models;

namespace SecureApi.Services
{
    public interface IAuthService
    {
      
            Task<AuthModel> RegisterAsync(RegisterationModel model);
            Task<AuthModel> GetTokenAsync(TokenRequestModel model);
            Task<string> AddRoleAsync(AddRoleModel model);
            Task<AuthModel> RefreshTokenAsync(string token);
            Task<bool> RevokeTokenAsync(string token);

    }
}
