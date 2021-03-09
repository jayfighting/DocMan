using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper.Configuration;
using LD.DocMan.Application.Contracts.Infrastructure.FileSystem;
using LD.DocMan.Infrastructure.FileSystem;
using Microsoft.Extensions.DependencyInjection;

namespace LD.DocMan.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<IDocumentReader, DocumentReader>();
            services.AddTransient<IDocumentWriter, DocumentWriter>();
            return services;
        }
    }
}
