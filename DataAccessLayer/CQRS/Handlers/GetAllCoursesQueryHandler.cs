using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Concrete;
using DataAccessLayer.CQRS.Results;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetAllCoursesQueryHandler
    {
        private readonly Context _context;

        public GetAllCoursesQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllCoursesQueryResult> Handle()
        {
            var values = _context.Courses.Select(x =>
            new GetAllCoursesQueryResult
            {
                Title = x.Title,
                Description = x.Description,
                Hour = x.Hour,
                Price = x.Price
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
