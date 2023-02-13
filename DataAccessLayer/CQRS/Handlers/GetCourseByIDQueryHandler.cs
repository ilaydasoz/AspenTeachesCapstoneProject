using System;
using DataAccessLayer.Concrete;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Results;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetCourseByIDQueryHandler
    {
        private readonly Context _context;

        public GetCourseByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetCourseByIDQueryResult Handle(GetCourseByIDQuery query)
        {
            var values = _context.Courses.Find(query.id);

            return new GetCourseByIDQueryResult
            {
                CourseID = values.CourseID,
                Title = values.Title,
                Description = values.Description,
                Hour = values.Hour,
                Price = values.Price
            };
        }
    }
}

