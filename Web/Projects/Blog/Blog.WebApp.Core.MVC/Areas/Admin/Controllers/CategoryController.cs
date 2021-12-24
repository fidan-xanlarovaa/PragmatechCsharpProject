using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        [Area("Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
