using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcUniform.Pages
{
    public class OptionalModel : PageModel
    {
        private readonly ILogger<OptionalModel> _logger;

        public OptionalModel(ILogger<OptionalModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}