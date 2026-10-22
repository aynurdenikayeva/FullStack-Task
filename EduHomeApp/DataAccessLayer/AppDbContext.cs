using EduHomeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHomeApp.DataAccessLayer
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Home> homes { get; set; }
        public DbSet<About> about { get; set; }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Course> courses { get; set; } 
        public DbSet<Blog> blogs { get; set; }
    }
}
