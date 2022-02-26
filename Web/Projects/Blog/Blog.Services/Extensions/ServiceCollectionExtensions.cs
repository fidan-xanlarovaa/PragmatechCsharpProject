using Blog.Data.Abstract;
using Blog.Data.Concrete;
using Blog.Data.Concrete.EntityFramework.Context;
using Blog.Entities.Concrete;
using Blog.Services.Abstract;
using Blog.Services.Concret;
using Microsoft.Extensions.DependencyInjection;


namespace Blog.Services.Extensions
{
    
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>();

            services.AddIdentity<User, Role>(options =>
            {
                /// Burda biz login logout olan zaman qoyduqumuz qaydalari qeyd edirik
                
                // user password options (PS: bu settingler eslinde default olaraq da ble verilib yen yazmasaqd olardi)
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;

                // Default User settings
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<BlogDbContext>(); // elave edilmesi zeruridir. Bizim yaratdiqimiz entityleri yeni
                                                          // IdentityStore-leri tanisin deye elave edirik

            /// <summary>
            /// Bu metodlar bize insatance yaradib veririr. Adindanda goruduyu kimi yeni srviceleri load edir
            /// </summary>
            services.AddScoped<IUnitOfWork, UnitOfWork>(); //
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAuthService, AuthManager>();
            return services;
        }

    }

}
    
