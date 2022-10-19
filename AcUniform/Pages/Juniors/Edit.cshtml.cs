using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AcUniform.Data;
using AcUniform.Models;

namespace AcUniform.Pages.Juniors
{
    public class EditModel : PageModel
    {
        private readonly AcUniform.Data.AcUniformContext _context;

        public EditModel(AcUniform.Data.AcUniformContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Junior Junior { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Junior == null)
            {
                return NotFound();
            }

            var junior =  await _context.Junior.FirstOrDefaultAsync(m => m.JuniorID == id);
            if (junior == null)
            {
                return NotFound();
            }
            Junior = junior;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Junior).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JuniorExists(Junior.JuniorID))
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

        private bool JuniorExists(int id)
        {
          return _context.Junior.Any(e => e.JuniorID == id);
        }
    }
}
