using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WEB_02.Models;

namespace WEB_02.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        public int Count { get; private set; } = 3;
        public List<Component>Components;
        public void OnGet()
        {

        }
        public void OnPost(List<Component> components)
        {
            Components = components;
        }

    }
}
