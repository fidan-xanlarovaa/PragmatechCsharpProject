using Blog.Entities.Dtos;
using Blog.Services.Abstract;
using Blog.Shared.Extensions;
using Blog.Shared.Utilities.ComplexTypes;
using Blog.WebApp.Core.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {

        public readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService; //Burda new ile de instance ala bilerik amma bu duzgun deyil.. Burda biz deyirik ki, eger bunun istancesi
                                                //varsa onu getir.
        }

        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAllAsync();

            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("_CreatePartial");
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddDto request)
        {
            if (ModelState.IsValid) //== true
            {
                var result = await _categoryService.AddAsync(request, "Admin");

                if (result.IsSuccess)
                {
                    var successViewModel = new CategoryCreateAjaxViewModel()
                    {
                        Result = result,
                        Partial = await this.RenderViewToStringAsync("_CreatePartial", request)
                    };
                    return Json(successViewModel);
                }
            }
            var errorViewModel = new CategoryCreateAjaxViewModel()
            {
                AddDto = request,
                Partial = await this.RenderViewToStringAsync("_CreatePartial", request)
            };

            return Json(errorViewModel);
        }
        /**/

        #region update
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _categoryService.GetUpdateDtoAsync(id);
            return PartialView("_UpdatePartial", result.Data);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CategoryUpdateDto request)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.UpdateAsync(request, "Admin");

                if (result.IsSuccess)
                {
                    var successViewModel = new CategoryUpdateAjaxViewModel()
                    {
                        Result = result,
                        Partial = await this.RenderViewToStringAsync("_UpdatePartial", request)
                    };
                    return Json(successViewModel);
                }
            }

            var errorViewModel = new CategoryUpdateAjaxViewModel()
            {
                Partial = await this.RenderViewToStringAsync("_UpdatePartial", request)
            };

            return Json(errorViewModel);
        }


        #endregion
        #region delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await _categoryService.DeleteAsync(id, "Admin");
            return Json(result);
        }
        #endregion
    }
}