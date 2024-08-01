using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
