using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string GitHubUrl { get; set; }
        public string LinkedinUrl { get; set; }
    }
}
