using Microsoft.AspNetCore.Mvc;

namespace Portal.WEBUI.ViewComponent.Default
{
    public class _EmployeePartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public async Task< IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
