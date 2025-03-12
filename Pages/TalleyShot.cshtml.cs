using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demous_Studios.Pages;

public class TalleyShotModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public TalleyShotModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

