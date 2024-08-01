using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WEBUI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
