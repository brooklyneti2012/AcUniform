using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcUniform.Pages
{
    public class JuniorStudentsModel : PageModel
    {
        private readonly ILogger<JuniorStudentsModel> _logger;

        public JuniorStudentsModel(ILogger<JuniorStudentsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}