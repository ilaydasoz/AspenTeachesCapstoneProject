using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Hour { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
