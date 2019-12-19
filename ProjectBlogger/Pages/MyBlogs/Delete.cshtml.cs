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
    public class DeleteModel : PageModel
    {
        private readonly ProjectBlogger.Data.BloggerContext _context;

        public DeleteModel(ProjectBlogger.Data.BloggerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyBlogs = await _context.MyBlogss.FindAsync(id);

            if (MyBlogs != null)
            {
                _context.MyBlogss.Remove(MyBlogs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
