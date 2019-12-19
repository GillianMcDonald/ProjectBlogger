using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectBlogger.Data;
using ProjectBlogger.Models;

namespace ProjectBlogger
{
    public class IndexModel : PageModel
    {
        private readonly ProjectBlogger.Data.BloggerContext _context;

        public IndexModel(ProjectBlogger.Data.BloggerContext context)
        {
            _context = context;
        }

        public IList<MyBlogs> MyBlogs { get;set; }

        public async Task OnGetAsync()
        {
            MyBlogs = await _context.MyBlogss
                .Include(m => m.User).ToListAsync();
        }
    }
}
