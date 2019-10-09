using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD2._1.Data;

namespace CRUD2._1.Pages.MFT
{
    public class DeleteModel : PageModel
    {
        private readonly CRUD2._1.Data.ApplicationDbContext _context;

        public DeleteModel(CRUD2._1.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufactures = await _context.Manufactures.FindAsync(id);

            if (Manufactures != null)
            {
                _context.Manufactures.Remove(Manufactures);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
