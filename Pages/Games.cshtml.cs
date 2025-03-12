using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demous_Studios.Pages;

public class GamesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public GamesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
