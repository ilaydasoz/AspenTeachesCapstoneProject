using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string GitHubUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public bool Status { get; set; }
    }
}
