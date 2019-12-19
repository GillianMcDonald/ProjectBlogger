using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectBlogger.Data;
using ProjectBlogger.Models;

namespace ProjectBlogger
{
    public class CreateModel : PageModel
    {
        private readonly ProjectBlogger.Data.BloggerContext _context;

        public CreateModel(ProjectBlogger.Data.BloggerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserID", "UserID");
            return Page();
        }

        [BindProperty]
        public MyBlogs MyBlogs { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyBlogss.Add(MyBlogs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
