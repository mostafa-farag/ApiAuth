using ApiJwt.Models;
using Microsoft.AspNetCore.Identity;


namespace ApiJwt.Service
{
    public interface IAuthService
    {
       
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        //Task<string> AddRoleAsync(AddRoleModel model);
    }
}
