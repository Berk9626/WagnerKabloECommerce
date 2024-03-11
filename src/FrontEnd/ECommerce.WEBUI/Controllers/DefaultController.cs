using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WEBUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
