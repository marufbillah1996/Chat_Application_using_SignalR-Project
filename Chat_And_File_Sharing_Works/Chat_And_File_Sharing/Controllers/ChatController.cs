using Microsoft.AspNetCore.Mvc;

namespace Chat_And_File_Sharing.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
