﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Services.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceCollectionExtensions).Assembly);
            return services;
        }
    }
}
