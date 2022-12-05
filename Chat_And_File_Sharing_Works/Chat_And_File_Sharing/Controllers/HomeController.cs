using Microsoft.AspNetCore.Mvc;

namespace Chat_And_File_Sharing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
