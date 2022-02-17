using AutoMapper;
using Blog.Entities;
using Blog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()

        {
            CreateMap<CategoryDto, Category>();
            CreateMap<Category,CategoryDto>();

            CreateMap<CategoryAddDto, Category>();
            // !!! .ForMember(dest=>dest.Description,opt=>opt.MapFrom(src=>src.Description2)); 1 ci olan CategoryDto ikinci categorydir
            CreateMap<Category, CategoryAddDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();

            /// <summary>
            /// ReverseMap ile Hem CategoryAddDto Categorye hem de  Category CategoryAddDto-a cevrilir, lakin fieldlarin adi ferqlimolarsa bu problem yaradar deye
            /// daha cox yuxaridaki formadan istifade olunur(yeni ayrica yazilir her ikisi ucu ve daha sonra ForMember() funksiyasi ile tenzimlemeler edilir
            /// </summary>

            // !!! CreateMap<CategoryAddDto, Category>().ReverseMap();

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