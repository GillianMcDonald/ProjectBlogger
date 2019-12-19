using System;
using System.Collections.Generic;
using ProjectBlogger.Models;

namespace ProjectBlogger.View_Models
{
    public class HomeViewModel
    {
        public IEnumerable<MyBlogs> BlogOfTheWeek { get; set; }
    }
}
