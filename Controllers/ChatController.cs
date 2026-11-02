using Microsoft.AspNetCore.Mvc;

namespace SignalR_MVC_Practice.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Chat/index1
        public IActionResult Index1()
        {
            return View("Chat");
        }
    }
}
