using Microsoft.AspNetCore.Mvc;

namespace CarBook.webUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
