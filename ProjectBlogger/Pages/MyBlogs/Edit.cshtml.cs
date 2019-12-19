using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectBlogger.Data;
using ProjectBlogger.Models;

namespace ProjectBlogger
{
    public class EditModel : PageModel
    {
        private readonly ProjectBlogger.Data.BloggerContext _context;

        public EditModel(ProjectBlogger.Data.BloggerContext context)
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
           ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserID", "UserID");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MyBlogs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyBlogsExists(MyBlogs.MyBlogsID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MyBlogsExists(int id)
        {
            return _context.MyBlogss.Any(e => e.MyBlogsID == id);
        }
    }
}
