
using System.Text.Json.Serialization;
using Blog.Services.AutoMapper;
using Blog.Services.Extensions;
using Blog.Shared.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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


            services.AddSession();
            /// <summary>
            ///
            /// Biz AJAX ile isleyeceyik deye geriye json dat qaytaracayiq, bu bize bezi cetinlikler yaradir
            /// (meselen: json datanin icerisinde sonsuz sayda loop edir ve data gelibse onlarin hamsini gosterir amma bizim
            /// bunlarin hamsini UI gostermeyimiz duzgun deyil, sadece backend de baxanda o datanin movcud olduqunu gormeliyik
            /// (browseri yuklememek ucun)  javascriptde biz entity adlarini kicik yaziriq, C#  ise boyuk) Bunmetodlardan istifade
            /// ederek bu probleri rahatliqla aradan qaldirirq ve C# developer ucun daha oxunaqli edirik. (.AddNewtonsoftJson() ve AddJsonOptions() dan sohbet gedir)

            /// </summary>

            services.LoadServices(); //Service layerimizde olan UserManager,CatageroyManager ve s. instancesini yaradan extension
                                     //metodumuzu caqiririq
            services.LoadSharedServices(); //Shared layerimizde olan FileHelperin instancesini yaradan extension metodumuzu caqiririq

            services.AddAutoMapper(typeof(CategoryProfile), typeof(UserProfile));

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Admin/Auth/Login");
                options.LogoutPath = new PathString("/Admin/Auth/Logout");
                options.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");

                options.Cookie = new CookieBuilder()
                {
                    Name = "BlogProject",

                    // xss cross site scripting
                    /*
                     * Asagidaki js kodu ile web page uzerindeki cookie melumatlarini elde etmek mumkundur.
                     *
                     * {
                     *  var cookie=document.cookie;
                     *  window.alert(cookie);
                     * }
                     *
                     * Lakin http-only cookie-lere bu qeder asan reach ede bilmirik.
                     * bu tip attack-lar XSS (Cross Site Scripting) adlanir.
                     */
                    HttpOnly = true,
                    /*
                     * Cross site Request Forgery 'CSRF' attackinin qarshisini almaq ucun istifade edilir,
                     * web app-e userlerden elave kiminse her hanssa bir appden her hansisa bir userin cookie
                     * melumatindan istifade ederek request ata bilmesinin qarshisini alir.
                     */
                    SameSite = SameSiteMode.Strict,
                    /*
                     * sameAsRequest hem http hem https requestleri qebul edir. Biz indi development merhelesindeyik deye bele
                     * vermisik. Production merhelesinde, security sertifikati aldiqdan sonra(ekser hallarda odenisli olsa da,
                     * bezen odenissiz versiyalari da olur) yalniz https ileislemesini temin edeceyik. Bunun ucun de                    
                     * CookieSecurePolicy.SameAsRequest yox CookieSecurePolicy.Always yazacayiq.
                     * Duzgun yeni productionda olan app-da  CookieSecurePolicy.Always olmalidir
                     */
                    SecurePolicy = CookieSecurePolicy.SameAsRequest, // Always
                };
                /*
                 * Cookieler bizim browserimizde application hissesinde yazilir. Onlar browserde en uzun muddetli yaddas sayilir
                 * ve digerleri kimi browser baqlananda silinmirler. Lakin onlarin daim orda qalmasi security cehetden tehlukelidir.
                 * Buna gore de biz mueeyyen muddetden bir userden yeniden ligin olmasii teleb edirik.
                 */
                options.SlidingExpiration = true; // Bir muddetden sonra cookie yaddasi silinsin
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7); // hansi muddetden bir cookie yaddasi silinsin.
            });


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

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); //adminin home controllerinde [Authorize(Roles ="Admin")] atributunu qeyd etdikden sonra 
            app.UseAuthorization(); //gelib burda bu iki metodu yaziriq. 1 cinin menasi "Sen kimsen?"--- bu metod seni login 
                                    //path=e yonlendirir. ikincinin menasi "Bura girmeye icazen varmi?"---bu metod atribut 
                                    //vasitesi ile senin Admin olub olmadiqi yoxlayir Eger o atributu controllerde qeyd etmesek
                                    //middleware(yeni bu deyqe ilduqumuz hisse) bunu basa dusmez.

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
