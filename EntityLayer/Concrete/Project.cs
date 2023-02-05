using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GitHubUrl { get; set; }
        public bool IsPrivate { get; set; }
    }
}
