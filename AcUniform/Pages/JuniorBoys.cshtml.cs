using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcUniform.Pages
{
    public class JuniorBoysModel : PageModel
    {
        private readonly ILogger<JuniorBoysModel> _logger;

        public JuniorBoysModel(ILogger<JuniorBoysModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}