using System;
namespace DataAccessLayer.CQRS.Results
{
    public class GetCourseByIDQueryResult
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Hour { get; set; }
        public string Price { get; set; }
    }
}
