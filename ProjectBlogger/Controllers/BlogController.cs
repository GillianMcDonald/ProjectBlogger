using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBlogger.Models;
using ProjectBlogger.View_Models;

namespace ProjectBlogger.Controllers
{
        //[Authorize]
        public class BlogController : Controller
        {
            //this gives us access to the data that is in the repositories.  they are fields which don't get initialised 
            //automatically so we need a constructor 
            private readonly IBlogRepository _blogRepository;
            private readonly IUserRepository _userRepository;

            //below is the constructor. pass in the repositories that get injected into the controller as they've been added
            //in the start up configure services.  
            public BlogController(IBlogRepository blogRepository, IUserRepository userRepository)
            {
                //set loocal blog and user repositories to the ones that are going to be injected 
                _blogRepository = blogRepository;
                _userRepository = userRepository;
            }

            //now need an action method to handle the incoming request.  ViewResult shows it's expecting a view to be returned
            //pass the blog repository.AllBlogs so we can see all the blogs when this is called 

            public ViewResult BlogList()
            {
                BlogListViewModel blogListViewModel = new BlogListViewModel();
                blogListViewModel.MyBlogs = _blogRepository.AllBlogs;

                //blogListViewModel.CurrentUser = "Can i get the logged in username to appear here!";
                return View(blogListViewModel);

            }

            //this action is used for when you click on the name of a post it opens up the full details on a new page that you can't 
            //navigate too separately.  
            public IActionResult BlogDetails(int id)
            {
                var blog = _blogRepository.GetBlogById(id);
                if (blog == null)
                    return NotFound();
                return View(blog);
            }

            public IActionResult UserBlogs()
            {
                //want to show signed in user blogs
                //want to show facility to upload / edit blogs 

                return View("Index");
            }
        }
}
