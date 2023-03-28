using Business.Abstract;
using Business.Concrete;
using Business.Repositories;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using AuthenticationService = Microsoft.AspNetCore.Authentication.AuthenticationService;
using IAuthenticationService = Microsoft.AspNetCore.Authentication.IAuthenticationService;

namespace API.Installers.Services
{
    public class InterfaceInstaller:IServiceInstaller
    {
        public void InstallService(IServiceCollection services)
        {
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton(typeof(IServiceRepository<>), typeof(ServiceRepository<,>));
            
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IGenderService, GenderService>();

        }
    }
}