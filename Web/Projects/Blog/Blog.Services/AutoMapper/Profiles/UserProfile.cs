using AutoMapper;
using Blog.Entities;
using Blog.Entities.Concrete;
using Blog.Entities.Dtos;
using Blog.Entities.Dtos.User;
namespace Blog.Services.AutoMapper
{
    
        public class UserProfile : Profile
        {
            public UserProfile()
            {
                CreateMap<User, UserDto>();
                CreateMap<User, UserUpdateDto>();
                CreateMap<UserAddDto, User>();
                CreateMap<UserUpdateDto, User>();
                CreateMap<PasswordDto, User>();
                CreateMap<User, PasswordDto>();
        }
        }
    
}

/// <summary>
/// 
/// Automapperin komeyi ile biz Service de her defe bize geln dto nu uyqun tipe cevirme zehmetinden xilas oluruq 
/// (yeni  bundan:  var entity = new Category(dto.Name, dto.Description, dto.Note);)
/// Buna gore de her entitye uyqun Profile class yaradib isimizi avtomatiklesdiririk
/// 
/// Auto Mapper bizi yazdiqimiz entitylerdeki atributlari onlarin adlarina uyqun uyqunladirir, eger adlar ferqlidirse o zaman biz ForMember() extesion metodu ile 
/// hansi atributu hansina map elemeli olduqunu bildiririk.(yeni custom olaraq bildiririk)
/// 
/// </summary>

/// <summary>
/// 
/// </summary>