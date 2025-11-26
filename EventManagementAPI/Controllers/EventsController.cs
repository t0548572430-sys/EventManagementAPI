using Microsoft.AspNetCore.Mvc;

namespace EventManagementAPI.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
