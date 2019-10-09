using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD2._1.Data;

namespace CRUD2._1.Pages.MFT
{
    public class EditModel : PageModel
    {
        private readonly CRUD2._1.Data.ApplicationDbContext _context;

        public EditModel(CRUD2._1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Manufactures Manufactures { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufactures = await _context.Manufactures.FirstOrDefaultAsync(m => m.Ford == id);

            if (Manufactures == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Manufactures).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufacturesExists(Manufactures.Ford))
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

        private bool ManufacturesExists(string id)
        {
            return _context.Manufactures.Any(e => e.Ford == id);
        }
    }
}
