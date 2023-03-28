using DataAccess.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace API.Installers.Services
{
    public class DbInstaller : IServiceInstaller, IConfigureInstaller
    {
        public void InstallService(IServiceCollection services)
        {
            services.AddDbContext<ServiceContext>(
                o =>
                {
                    o.UseSqlServer(@"Server=SERVER_NAME;Database=DB_NAME;User=USER;Password=PASSWORD;");
                }, ServiceLifetime.Singleton
        );
    }

        public void InstallConfigure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var context = app.ApplicationServices.GetService<ServiceContext>();
            context?.Database?.Migrate();
        }
    }
}