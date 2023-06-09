﻿using Microsoft.Extensions.DependencyInjection;

namespace API.Installers
{
    public interface IServiceInstaller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        void InstallService(IServiceCollection services);
    }
}