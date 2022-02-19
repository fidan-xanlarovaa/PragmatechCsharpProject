using Blog.Entities.Dtos;
using Blog.Entities.Dtos.User;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Models
{
    public class UserUpdateAjaxViewModel
    {
        public UserUpdateDto UpdateDto { get; set; }
        public string Partial { get; set; }
        public IResult<UserDto> Result { get; set; }
    }
}
