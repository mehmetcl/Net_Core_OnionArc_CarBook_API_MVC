﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
