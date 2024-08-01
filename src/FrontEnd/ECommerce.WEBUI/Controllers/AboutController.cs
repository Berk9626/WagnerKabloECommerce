using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WEBUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
