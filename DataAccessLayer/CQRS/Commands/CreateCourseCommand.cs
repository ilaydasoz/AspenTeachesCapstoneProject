using System;
namespace DataAccessLayer.CQRS.Commands
{
    public class CreateCourseCommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Hour { get; set; }
        public string Price { get; set; }
    }
}
