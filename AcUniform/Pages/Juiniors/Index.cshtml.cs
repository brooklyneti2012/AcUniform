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
    public class IndexModel : PageModel
    {
        private readonly AcUniform.Data.AcUniformContext _context;

        public IndexModel(AcUniform.Data.AcUniformContext context)
        {
            _context = context;
        }

        public IList<Junior> Junior { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Junior != null)
            {
                Junior = await _context.Junior.ToListAsync();
            }
        }
    }
}
