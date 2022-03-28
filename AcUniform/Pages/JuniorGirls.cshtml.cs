using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcUniform.Pages
{
    public class JuniorGirlsModel : PageModel
    {
        private readonly ILogger<JuniorGirlsModel> _logger;

        public JuniorGirlsModel(ILogger<JuniorGirlsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}