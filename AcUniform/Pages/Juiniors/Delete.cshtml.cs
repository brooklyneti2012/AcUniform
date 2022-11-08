using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcUniform.Data;
using AcUniform.Models;

namespace AcUniform.Pages.Juiniors
{
    public class DeleteModel : PageModel
    {
        private readonly AcUniform.Data.AcUniformContext _context;

        public DeleteModel(AcUniform.Data.AcUniformContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Junior == null)
            {
                return NotFound();
            }
            var junior = await _context.Junior.FindAsync(id);

            if (junior != null)
            {
                Junior = junior;
                _context.Junior.Remove(Junior);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
