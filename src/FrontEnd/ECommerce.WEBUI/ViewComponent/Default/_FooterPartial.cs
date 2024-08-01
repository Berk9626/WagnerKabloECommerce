using Microsoft.AspNetCore.Mvc;

namespace Portal.WEBUI.ViewComponent.Default
{
    public class _FooterPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public async Task< IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
