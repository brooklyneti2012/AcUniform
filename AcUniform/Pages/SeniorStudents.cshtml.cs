using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcUniform.Pages
{
    public class SeniorStudentsModel : PageModel
    {
        private readonly ILogger<SeniorStudentsModel> _logger;

        public SeniorStudentsModel(ILogger<SeniorStudentsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}