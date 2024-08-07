using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace AppConfigurationReferencesSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly string applicationName;

        public IndexModel(ILogger<IndexModel> logger, IOptionsMonitor<ApplicationOptions> applicationOptionsMonitor)
        {
            _logger = logger;
            applicationName = applicationOptionsMonitor.CurrentValue.ApplicationName;
        }

        public void OnGet()
        {

        }
    }
}
