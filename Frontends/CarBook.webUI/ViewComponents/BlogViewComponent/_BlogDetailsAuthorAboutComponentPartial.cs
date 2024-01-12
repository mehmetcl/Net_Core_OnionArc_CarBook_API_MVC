using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.ViewComponents.BlogViewComponent
{
    public class _BlogDetailsAuthorAboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
