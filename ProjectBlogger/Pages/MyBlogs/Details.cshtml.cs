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
    public class DetailsModel : PageModel
    {
        private readonly ProjectBlogger.Data.BloggerContext _context;

        public DetailsModel(ProjectBlogger.Data.BloggerContext context)
        {
            _context = context;
        }

        public MyBlogs MyBlogs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyBlogs = await _context.MyBlogss
                .Include(m => m.User).FirstOrDefaultAsync(m => m.MyBlogsID == id);

            if (MyBlogs == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
