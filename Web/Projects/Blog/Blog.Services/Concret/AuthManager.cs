using Blog.Entities.Concrete;
using Blog.Entities.Dtos.Auth;
using Blog.Services.Abstract;
using Blog.Shared.Localization;
using Blog.Shared.Utilities.Abstract;
using Blog.Shared.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Concret
{
    public class AuthManager : BaseServiceResult, IAuthService
    {
        #region fields

        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        #endregion

        #region ctors


        public AuthManager(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        #endregion

        #region methods
        #region login
        public async Task<IResult<bool>> Login(LoginDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);

            if(user is null)
            {
                return Error<bool>(BaseLocalization.NoDataAvailableOnRequest);
            }

            var signInResult = await _signInManager.PasswordSignInAsync(user, dto.Password, dto.RememberMe, false);

            if (!signInResult.Succeeded)
                return Error<bool>(BaseLocalization.LoginFailed);

            return Ok(true);

            
        }



        #endregion

        #region logout


        public async void Logout()
        {
          await _signInManager.SignOutAsync();
        }

        #endregion
        #endregion

    }
}
