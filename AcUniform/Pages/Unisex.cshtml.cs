using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcUniform.Pages
{
    public class UnisexModel : PageModel
    {
        private readonly ILogger<UnisexModel> _logger;

        public UnisexModel(ILogger<UnisexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}