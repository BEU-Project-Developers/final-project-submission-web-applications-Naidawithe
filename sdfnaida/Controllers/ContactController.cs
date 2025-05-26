using Microsoft.AspNetCore.Mvc;

namespace sdfnaida.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
