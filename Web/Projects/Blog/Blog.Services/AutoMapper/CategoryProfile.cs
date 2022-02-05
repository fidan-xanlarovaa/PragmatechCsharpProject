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
            CreateMap<Category, CategoryDto>();

            CreateMap<CategoryAddDto, Category>();

            CreateMap<CategoryUpdateDto, Category>();

            CreateMap<Category, CategoryUpdateDto>();

            //.ReverseMap();
            CreateMap<Category, CategoryAddDto>();

            //.ForMember(dest=>dest.Description,opt=>opt.MapFrom(src=>src.Description2));
        }
    }


}
