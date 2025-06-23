using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Application.Interfaces.Services;
using SocialNetwork.Infrastructure.Services;

namespace SocialNetwork.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, MediatR.Mediator>()
                .AddTransient<IAuthService, AuthService>();
        }
    }
}