using Blog.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    //[Authorize(Roles = "Editor")]
    //[Authorize(Roles = "Member")]
    public class DefaultUser : Controller
    {
        #region fields

        private readonly IUserService _service;
        #endregion
        #region ctor
        public DefaultUser(IUserService service)
        {
            _service = service;
        }
        #endregion



        [HttpGet]
        public async Task<IActionResult> ChangePassword(int id)
        {
            var result = await _service.GetPasswordDtoAsync(id);
            return View(result.Data);
        }
    }
}
