using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Entities.Dtos.Auth;
using Blog.Entities.Dtos.User;
using Blog.Shared.Utilities.Abstract;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.Services.Abstract
{

    public interface IAuthService
    {
        Task<IResult<bool>> Login(LoginDto dto);
        void Logout();
    }
}