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
    public class IndexModel : PageModel
    {
        private readonly AcUniform.Data.AcUniformContext _context;

        public IndexModel(AcUniform.Data.AcUniformContext context)
        {
            _context = context;
        }

        public string Name { get; set; }
        public string Price { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<Junior> Junior { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            Name = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            Price = sortOrder == "Price" ? "Price_desc" : "Price";
            CurrentFilter = searchString;
            IQueryable<Junior> JuniorIQ = from j in _context.Junior
                                          select j;

            if (!String.IsNullOrEmpty(searchString))
            {
                JuniorIQ = JuniorIQ.Where(j => j.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    JuniorIQ = JuniorIQ.OrderByDescending(j => j.Name);
                    break;
                case "Price":

                    break;
            }
        }
    }
}
