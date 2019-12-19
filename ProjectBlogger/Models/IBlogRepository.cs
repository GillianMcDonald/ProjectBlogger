using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBlogger.Models
{
    public interface IBlogRepository
    {
        IEnumerable<MyBlogs> AllBlogs { get; }
        IEnumerable<MyBlogs> BlogOfTheWeek { get; }

       MyBlogs GetBlogById(int blogId);

    }
}
