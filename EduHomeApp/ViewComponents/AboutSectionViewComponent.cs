using EduHomeApp.DataAccessLayer;
using EduHomeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHomeApp.ViewCompanents
{
    public class AboutSectionViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public AboutSectionViewComponent(AppDbContext context) 
        { 
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            About about = await _context.about.FirstOrDefaultAsync();
             return View(about);
        }
    }
}
