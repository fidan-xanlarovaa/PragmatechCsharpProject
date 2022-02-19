using Blog.Shared.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Shared.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadSharedServices(this IServiceCollection services)
        {
            services.AddSingleton<IFileHelper, FileHelper>(); //bunun instancesini bize 1 defe yarat
            return services;
        }

    }
}