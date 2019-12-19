using System;
using System.Collections.Generic;

using ProjectBlogger.Models;

namespace ProjectBlogger.View_Models
{
    public class BlogListViewModel
    {
        public IEnumerable<MyBlogs> MyBlogs { get; set; }


        public string CurrentUser { get; set; }
    }
}
