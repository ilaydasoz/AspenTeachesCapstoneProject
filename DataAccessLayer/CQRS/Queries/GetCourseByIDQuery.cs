using System;
namespace DataAccessLayer.CQRS.Queries
{
    public class GetCourseByIDQuery
    {
        public int id { get; set; }

        public GetCourseByIDQuery(int id)
        {
            this.id = id;
        }
    }
}
