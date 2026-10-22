using Microsoft.AspNetCore.Mvc;

namespace EduHomeApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
