﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.ViewComponents.UILayoutViewComponents
{
    public class _HeadUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
