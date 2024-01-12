using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.webUI.Controllers
{
    public class ServiceController : Controller
    {

      
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetler";
			ViewBag.v1 = "Hizmetlerimiz";
			return View();
        }
    }
}
