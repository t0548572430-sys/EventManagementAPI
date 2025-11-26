using Microsoft.AspNetCore.Mvc;

namespace EventManagementAPI.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
