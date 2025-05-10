using Microsoft.AspNetCore.Mvc;

namespace SignalRCoreWebRTC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}