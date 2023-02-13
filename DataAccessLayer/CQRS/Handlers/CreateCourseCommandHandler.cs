using System;
using DataAccessLayer.Concrete;
using DataAccessLayer.CQRS.Commands;

namespace DataAccessLayer.CQRS.Handlers
{
    public class CreateCourseCommandHandler
    {
        private readonly Context _context;

        public CreateCourseCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateCourseCommand command)
        {
            _context.Courses.Add(new EntityLayer.Concrete.Course
            {
                Title = command.Title,
                Description = command.Description,
                Hour = command.Hour,
                Price = command.Price
            });

            _context.SaveChanges();
        }
    }
}
