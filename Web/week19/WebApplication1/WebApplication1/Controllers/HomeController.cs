using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] /*Bu gorsenmese bele default olaraq movcud olur */

        public IActionResult Index()
        {
            return View();
        }
    }
}
