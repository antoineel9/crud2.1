using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD2._1.Data;

namespace CRUD2._1.Pages.Car
{
    public class IndexModel : PageModel
    {
        private readonly CRUD2._1.Data.ApplicationDbContext _context;

        public IndexModel(CRUD2._1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cars> Cars { get;set; }

        public async Task OnGetAsync()
        {
            Cars = await _context.Cars.ToListAsync();
        }
    }
}
