
namespace Views;

using Microsoft.AspNetCore.Mvc.RazorPages;

public class Index : PageModel
{
    public string? Message {get;set;}

    public void OnGet()
    {
        Message = "Hello World";
    }
}
