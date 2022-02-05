using Blog.Services.AutoMapper;
using Blog.Services.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Blog.WebApp.Core.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation() // Bununla Viewlarda etdiyimiz(css,html) ani deyisiklikleri yaddasda saxlaya bileceyik. Runtime vaxti

                .AddNewtonsoftJson(options => 
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; // ic ice olan datalari gorme yeni ignor et
                }) 
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); //  enumu mene int yox string olaraq qaytar
                });

            /// <summary>
            ///
            /// Biz AJAX ile isleyeceyik deye geriye json dat qaytaracayiq, bu bize bezi cetinlikler yaradir
            /// (meselen: json datanin icerisinde sonsuz sayda loop edir ve data gelibse onlarin hamsini gosterir amma bizim
            /// bunlarin hamsini UI gostermeyimiz duzgun deyil, sadece backend de baxanda o datanin movcud olduqunu gormeliyik
            /// (browseri yuklememek ucun)  javascriptde biz entity adlarini kicik yaziriq, C#  ise boyuk) Bunmetodlardan istifade
            /// ederek bu probleri rahatliqla aradan qaldirirq ve C# developer ucun daha oxunaqli edirik. (.AddNewtonsoftJson() ve AddJsonOptions() dan sohbet gedir)

            /// </summary>

            services.LoadServices();

            services.AddAutoMapper(typeof(CategoryProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>


            {


                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapDefaultControllerRoute();


            });
        }
    }
}
