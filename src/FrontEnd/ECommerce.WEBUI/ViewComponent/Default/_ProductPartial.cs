﻿using Microsoft.AspNetCore.Mvc;

namespace Portal.WEBUI.ViewComponent.Default
{
    public class _ProductPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
