using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace sdfnaida.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
