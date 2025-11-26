using Microsoft.AspNetCore.Mvc;

namespace EventManagementAPI.Controllers
{
    public class VendorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
