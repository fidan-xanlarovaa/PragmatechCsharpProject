using Blog.Entities.Dtos;
using Blog.Entities.Dtos.User;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Models
{
    public class UserCreateAjaxViewModel
    {
        /// <summary>
        /// Action==true it means Create
        /// Action==false it means Update
        /// </summary>
        public bool Action { get; private set; }
        public UserAddDto AddDto { get; set; }
        public string Partial { get; set; }
        public IResult<UserDto> Result { get; set; }
    }
}
