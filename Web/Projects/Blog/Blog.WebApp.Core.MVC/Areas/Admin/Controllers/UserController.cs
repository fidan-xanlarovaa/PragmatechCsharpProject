using Blog.Entities.Dtos.User;
using Blog.Services.Abstract;
using Blog.Shared.Extensions;
using Blog.WebApp.Core.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        #region fields

        private readonly IUserService _service;
        #endregion
        #region ctor
        public UserController(IUserService service)
        {
            _service = service;
        }
        #endregion

        #region methods
        #region loadData
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllAsync();

            return View(result);
        }
        #endregion

        #region create

        //create metodu registrationla eyni deyil. Burda admin ozu userleri create edir ve onlara responsibiltiler verir.

        [HttpGet] // Get metodu geriye partial View qaytarir.
        public IActionResult Create()
        {
            return PartialView("_CreatePartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // CSRF
        public async Task<IActionResult> Create(UserAddDto request)
        {
            if (ModelState.IsValid)
            {
                var result = await _service.AddAsync(request, "Admin");

                if (result.Errors.Any())
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (result.IsSuccess)
                {
                    var successViewModel = new UserCreateAjaxViewModel()
                    {
                        Result = result,
                        Partial = await this.RenderViewToStringAsync("_CreatePartial", request)
                    };
                    return Json(successViewModel);
                }
            }
            var errorViewModel = new UserCreateAjaxViewModel()
            {
                AddDto = request,
                Partial = await this.RenderViewToStringAsync("_CreatePartial", request)
            };

            return Json(errorViewModel);
        }
        #endregion

        #region update
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _service.GetUpdateDtoAsync(id);

            return PartialView("_UpdatePartial", result.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(UserUpdateDto request)
        {
            if (ModelState.IsValid)
            {
                var result = await _service.UpdateAsync(request, "Admin");

                if (result.Errors.Any())
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (result.IsSuccess)
                {
                    var successViewModel = new UserUpdateAjaxViewModel()
                    {
                        Result = result,
                        Partial = await this.RenderViewToStringAsync("_UpdatePartial", request)
                    };
                    return Json(successViewModel);
                }
            }
            var errorViewModel = new UserUpdateAjaxViewModel()
            {
                UpdateDto = request,
                Partial = await this.RenderViewToStringAsync("_UpdatePartial", request)
            };

            return Json(errorViewModel);
        }
        #endregion

        #region delete

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id, "Admin");
            return Json(result);
        }
        #endregion

        #region change password
        [HttpGet]
        [Authorize(Roles = "Admin,Editor,Member")]

        public async Task<IActionResult> ChangePassword()
        {
            //var result = await _service.GetUpdateDtoAsync(id);

            return PartialView("_ChangePasswordPartial");
        }

        #endregion

        #endregion
    }
}
