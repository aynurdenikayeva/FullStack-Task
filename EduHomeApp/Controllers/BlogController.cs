using Microsoft.AspNetCore.Mvc;

namespace EduHomeApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
