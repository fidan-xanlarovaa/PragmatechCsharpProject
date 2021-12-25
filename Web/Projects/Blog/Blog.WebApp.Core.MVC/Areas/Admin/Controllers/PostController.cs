using Blog.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApp.Core.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class PostController : Controller
    {
        public readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;

        }
        public async Task<IActionResult> Index()
        {
            var result = await _postService.GetAllAsync();
            return View(result.Data);
        }
    }
}

