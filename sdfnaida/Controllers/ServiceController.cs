using Microsoft.AspNetCore.Mvc;

namespace sdfnaida.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
