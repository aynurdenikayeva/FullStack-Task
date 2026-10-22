using EduHomeApp.Models;
using System.Collections.Generic;

namespace EduHomeApp.ViewModels
{
    public class HomeVM
    {
        public List<Home> Home { get; set; } 
        public List<Slider> Slider { get; set; }
        public List<Course> Courses { get; set; }
        public List<Blog> Blog { get; set; }



    }
}
