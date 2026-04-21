using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEB_02.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
