using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcUniform.Pages
{
    public class CartContentsModel : PageModel
    {
        private readonly ILogger<CartContentsModel> _logger;

        public CartContentsModel(ILogger<CartContentsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}