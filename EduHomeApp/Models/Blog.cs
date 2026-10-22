using System;

namespace EduHomeApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int CommentCount { get; set; }
        public string Title { get; set; }

    }
}
