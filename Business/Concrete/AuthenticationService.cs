using System.Security.Authentication;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Helpers;
using Core.Plugins.Authentication.Jwt;
using Core.Plugins.Authentication.Models;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Business.Concrete
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRepository<User> _userService;
        private readonly IJwtService _jwtService;
       

        public AuthenticationService(IRepository<User> accountRepository, IJwtService jwtService)
        {
            _userService = accountRepository;
            _jwtService = jwtService;
        }       

        public async Task<TokenInfo> LoginAsync(LoginRequestModel loginModel)
        {
            var account = await _userService.Get(x => x.Email == loginModel.Email);
            if (account == null) throw new(loginModel.Email+" Account is not found");

            if (account.IsBlocked)
                throw new AuthenticationException("Account is blocked");
            
            var verify =
                HashingHelper.VerifyPasswordHash(loginModel.Password, account.PasswordHash, account.PasswordSalt);
            if (!verify)
                throw new AuthenticationException("Password Wrong");

            var accessToken = _jwtService.CreateToken(new JwtCreateModel(account.Id,
                account.FirstName + " " + account.LastName));

            return accessToken;

        }

        public  Task LogoutAsync(int accountId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> RegisterAsync(RegisterRequestModel registerModel,string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = registerModel.Email,
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                PhoneNumber = registerModel.PhoneNumber,
                GenderId = registerModel.GenderId,
                UserClaim=registerModel.UserClaim,
                BranchOfficeId=registerModel.BranchOfficeId,
                IsBlocked=registerModel.IsBlocked,  
                Birthday=registerModel.Birthday,

            };
            await _userService.Insert(user);

            return user;
        }       
    }
}