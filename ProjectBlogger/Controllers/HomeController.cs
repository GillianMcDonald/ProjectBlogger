using System;
using Microsoft.AspNetCore.Mvc;
using ProjectBlogger.Models;
using ProjectBlogger.View_Models;

namespace ProjectBlogger.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public HomeController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BlogOfTheWeek = _blogRepository.BlogOfTheWeek
            };
            return View(homeViewModel);
        }

    }
}
