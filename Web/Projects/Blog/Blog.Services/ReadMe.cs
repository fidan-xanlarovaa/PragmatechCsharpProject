/// <summary>
/// 
/// DATA
/// 1. Auth brachi yaratdiq
/// 2. UserConfigurationda seedlerimizi elave eledik
///     2.1 CreatePasswordHash(User user, string password) -bu metod vasitesi ile pawwordu hashleyib geri qaytardiq 
///         Cunki biz databasede passwordleri aciq formada saxlamiriqki, sabah databemizi eger hacklenerse hemen hacker 
///         o passwordlari aciq sekilde gore bilmesin
///     2.2 member.PasswordHash = CreatePasswordHash(editor, "Member123!User"); - memberin PasswordHash propertisine 
///         CreatePasswordHash(editor, "Member123!User") deyerini verdik
///     2.3 builder.HasData(admin, editor, member);
/// 3. RoleConfigurationda seedlerimizi elave eledik 
///     3.1 Hem userde hem rolede id-leri elle vermisik, cunki ilk yarananlardir deye biz yaziriqki sonradan avtomatik
///         generate ede bilsin.
/// 4. UserRoleConfigurationda many-to-many elaqe qururuq
///     4.1 builder.HasKey(r => new { r.UserId, r.RoleId });
///     4.2 builder.ToTable("AspNetUserRoles", BlogDbContext.IDENTITY_SCHEMA);
/// 5. Migartionu silirik ve yeniden yaradiriq ki, seedlerimiz database duwsun
///     5.1 dotnet ef migrations add InitialCreate
///     5.2 dotnet ef database update
/// 
/// 
/// MVC-ADMIN
/// 6. Controllers/ AuthController.cs
/// 7. Views/Shared/ _LoginLayout.cshtml
/// 8. Views/Auth/ Login.cshtml
/// 9. Startup.cs - services.LoadServices();
///                 services.LoadSharedServices();
///                 services.AddAutoMapper(typeof(CategoryProfile), typeof(UserProfile));
///     metodlarimii services.ConfigureApplicationCookie() metodundan evvel caqiririq, cunki biz Identity-ni elave etmemisden
///     evvel Cokie settinglerimizi etdikde proqram run olarken bezi problemler yaranir, sehv yere redirect edir
/// 
/// 
/// 
/// ENTITIES
/// 10.Dtos/Auth/LoginDto.cs
/// 
/// 
/// MVC-ADMIN
/// 11.ButunView folderlerin index sehifelerine ViewBaglari elave edirik
/// 
/// 
/// SERVICES
/// 12.SignInManager<User>  and UserManager<User> types
/// 13. login and logout methods
/// 
/// 
/// MVC-ADMIN
/// 14. login and logout actions
/// </summary>
