using System.Threading.Tasks;
using Core.Plugins.Authentication.Models;
using DataAccess.Entities;

namespace Business.Abstract
{
    public interface IAuthenticationService 
    {
        /// <summary>
        /// Login Operation
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        Task<TokenInfo> LoginAsync(LoginRequestModel loginModel);

        /// <summary>
        /// Logout
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task LogoutAsync(int accountId);
        
        /// <summary>
        /// Register Operation
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        Task<User> RegisterAsync(RegisterRequestModel registerModel,string password);      
    }
}