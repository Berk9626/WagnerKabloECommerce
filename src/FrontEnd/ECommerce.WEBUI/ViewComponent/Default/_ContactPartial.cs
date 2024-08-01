using Microsoft.AspNetCore.Mvc;

namespace Portal.WEBUI.ViewComponent.Default
{
    public class _ContactPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
   
        public async Task< IViewComponentResult> InvokeAsync()
        {
            


            return View();
        }
    }
}
