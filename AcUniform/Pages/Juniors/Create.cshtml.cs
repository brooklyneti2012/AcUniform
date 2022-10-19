using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AcUniform.Data;
using AcUniform.Models;

namespace AcUniform.Pages.Juniors
{
    public class CreateModel : PageModel
    {
        private readonly AcUniform.Data.AcUniformContext _context;

        public CreateModel(AcUniform.Data.AcUniformContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Junior Junior { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Junior.Add(Junior);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
