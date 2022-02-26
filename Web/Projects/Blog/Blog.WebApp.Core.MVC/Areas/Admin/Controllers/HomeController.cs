using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        [Authorize]//(Roles ="Admin")] //Bunun sayesinde eger login etmirikse bizi startup classinda yazdiqimiz url-e gonderir
                   //options.LoginPath = new PathString("/Admin/Auth/Login");
        public IActionResult Index()
        {
            return View();
        }
    }
}
