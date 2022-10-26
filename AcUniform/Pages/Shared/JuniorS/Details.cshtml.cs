using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcUniform.Data;
using AcUniform.Models;

namespace AcUniform.Pages.Shared.JuniorS
{
    public class DetailsModel : PageModel
    {
        private readonly AcUniform.Data.AcUniformContext _context;

        public DetailsModel(AcUniform.Data.AcUniformContext context)
        {
            _context = context;
        }

      public Junior Junior { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Junior == null)
            {
                return NotFound();
            }

            var junior = await _context.Junior.FirstOrDefaultAsync(m => m.JuniorID == id);
            if (junior == null)
            {
                return NotFound();
            }
            else 
            {
                Junior = junior;
            }
            return Page();
        }
    }
}
