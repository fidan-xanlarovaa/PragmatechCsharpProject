using Blog.Data.Abstract;
using Blog.Data.Concrete;
using Blog.Data.Concrete.EntityFramework.Context;
using Blog.Entities.Concrete;
using Blog.Services.Abstract;
using Blog.Services.Concret;
using Microsoft.Extensions.DependencyInjection;


namespace Blog.Services.Extensions
{
    /// <summary>
    /// Bu metodlar bize insatnc yaradib veririr.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>();

            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<BlogDbContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryManager>();
            //services.AddScoped<IPostService, PostManager>();
            return services;
        }

    }
    //public static class ServiceCollectionExtensions
    //{
    //    public static IServiceCollection LoadServices(this IServiceCollection services)
    //    {
    //        services.AddDbContext<BlogDbContext>();
    //        services.AddScoped<IUnitOfWork, UnitOfWork>();
    //        services.AddScoped<ICategoryService, CategoryManager>();
    //        return services;
    //    }
    //}
}
