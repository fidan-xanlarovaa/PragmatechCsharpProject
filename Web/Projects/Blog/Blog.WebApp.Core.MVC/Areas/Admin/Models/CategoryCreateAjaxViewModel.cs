using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Models
{
    public class CategoryCreateAjaxViewModel
    {
        /// <summary>
        /// Action==true it means Create
        /// Action==false it means Update
        /// </summary>
        public bool Action { get; private set; }
        public CategoryAddDto AddDto { get; set; }
        public string Partial { get; set; }
        public IResult<CategoryDto> Result { get; set; }
    }

    public class CategoryUpdateAjaxViewModel
    {
        public CategoryUpdateDto UpdateDto { get; set; }
        public string Partial { get; set; }
        public IResult<CategoryDto> Result { get; set; }
    }
}
