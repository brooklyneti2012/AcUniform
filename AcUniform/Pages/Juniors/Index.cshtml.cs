using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcUniform.Data;
using AcUniform.Models;

namespace AcUniform.Pages.Juniors
{
    public class IndexModel : PageModel
    {
        private readonly AcUniform.Data.AcUniformContext _context;

        public IndexModel(AcUniform.Data.AcUniformContext context)
        {
            _context = context;
        }

        public IList<Junior> Junior { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var juniors = from j in _context.Junior
                          select j;
            if (!string.IsNullOrEmpty(SearchString))
            {
                juniors = juniors.Where(s => s.ClotheName.Contains(SearchString));
            }

            Junior = await juniors.ToListAsync();
        }

       
        
        
        
        
        //public async Task OnGetAsync()
        //{
        //    if (_context.Junior != null)
        //    {
        //        Junior = await _context.Junior.ToListAsync();
        //    }
        //}
    }
}
