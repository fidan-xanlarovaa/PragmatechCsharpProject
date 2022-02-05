using Blog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Models
{
    public class CategoryCreateAjaxViewModel
    {
        public CategoryAddDto AddDto { get; set; }
        public string Partial { get; set; }
        public CategoryDto Dto { get; set; }
    }

    public class CategoryUpdateAjaxViewModel
    {
        public CategoryUpdateDto UpdateDto { get; set; }
        public string Partial { get; set; }
        public CategoryDto Dto { get; set; }
    }
}
