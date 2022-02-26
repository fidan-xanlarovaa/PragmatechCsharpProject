using Blog.Entities.Concrete;
using Blog.WebAPP.CORE.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.ViewComponents
{/// <summary>
/// Controllere oxsa sa da View component daha ferqlidir. View componentin icinde bir nece action yaratmaq mumkun deyil
/// Viewcomponentin isi odur ki, her hansi bir parti goturur ve onun icerisinde dinamik emeliyyatlar aparir.
/// Sadece 1 metodu olur
/// </summary>
    public class LeftSideBarViewComponent:ViewComponent
    {
        #region fields

        private readonly UserManager<User> _userManager;
        #endregion

        #region ctor

        public LeftSideBarViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        #endregion

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User); // User haqqinda melumatlar

            var roles = await _userManager.GetRolesAsync(user); //Userin rolllari

            var viewModel = new UserWithRolesViewModel
            {
                User = user,
                Roles = roles
            };
            return View(viewModel);
        }
    }
}
