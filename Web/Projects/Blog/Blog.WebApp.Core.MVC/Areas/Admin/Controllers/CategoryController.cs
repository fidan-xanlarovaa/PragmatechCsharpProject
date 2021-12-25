using Blog.Services.Abstract;
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

            return View(result.Data);
        }
    }
}
