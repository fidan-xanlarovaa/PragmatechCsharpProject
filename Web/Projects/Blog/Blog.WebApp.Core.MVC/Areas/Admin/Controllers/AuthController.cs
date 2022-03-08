using Blog.Entities.Dtos.Auth;
using Blog.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Controllers
{
    [AllowAnonymous] //

    [Area("Admin")]
    public class AuthController : Controller
    {
        #region fields
        private readonly IAuthService _authService;
        #endregion

        #region ctors

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        #endregion

        #region login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _authService.Login(request);

            if (result.IsSuccess)
            {
                return RedirectToAction( "Index", "Home");
            }

            if (result.Errors.Any())
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }
            return View(request);


        }
        #endregion

        #region logout

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
             _authService.Logout();
            
            return RedirectToAction("Login","Auth");
        }
        #endregion

        #region access denied
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
        #endregion

        
    }
}
