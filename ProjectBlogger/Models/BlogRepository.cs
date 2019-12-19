using Microsoft.EntityFrameworkCore;
using ProjectBlogger.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectBlogger.Models
{
    public class BlogRepository : IBlogRepository
    {//this is going to interact with our database to show the info in that database so it needs
     // the appDbContext 
        private readonly BloggerContext _bloggerContext;

        //through constructor injection (as it's resigstered in service collection in the start up) we 
        //get access to the AppDbContext in our Blog Repository 
        public BlogRepository(BloggerContext bloggerContext)
        {
            _bloggerContext = bloggerContext;
        }

        public IEnumerable<MyBlogs> AllBlogs
        {
            get
            {
                return _bloggerContext.MyBlogss.Include(u => u.User);
            }
        }


        public IEnumerable<MyBlogs> BlogOfTheWeek
        {
            get
            {
                return _bloggerContext.MyBlogss.Include(u => u.User).Where(b => b.BlogOfTheWeek);
            }
        }

        public MyBlogs GetBlogById(int blogId)
        {
            return _bloggerContext.MyBlogss.FirstOrDefault(b => b.MyBlogsID == blogId);
        }

    
    }
}
