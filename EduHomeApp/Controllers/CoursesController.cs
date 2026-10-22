using Microsoft.AspNetCore.Mvc;

namespace EduHomeApp.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
