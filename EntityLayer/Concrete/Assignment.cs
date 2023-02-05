using System;
namespace EntityLayer.Concrete
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
    }
}
