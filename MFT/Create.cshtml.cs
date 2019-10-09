using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD2._1.Data;

namespace CRUD2._1.Pages.MFT
{
    public class CreateModel : PageModel
    {
        private readonly CRUD2._1.Data.ApplicationDbContext _context;

        public CreateModel(CRUD2._1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Manufactures Manufactures { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Manufactures.Add(Manufactures);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}