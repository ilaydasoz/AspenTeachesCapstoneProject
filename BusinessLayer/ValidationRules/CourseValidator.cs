using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Course name cannot be empty!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be empty!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price cannot be empty!");
            RuleFor(x => x.Hour).NotEmpty().WithMessage("Hour cannot be empty!");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Description is too long!");
            RuleFor(x => x.Hour).MaximumLength(3).WithMessage("Course hour is too much!");
            RuleFor(x => x.Title).MinimumLength(15).WithMessage("Course name must be 15 characters at least!");
            RuleFor(x => x.Title).MinimumLength(20).WithMessage("Description must be 20 characters at least!");
            RuleFor(x => x.Description).NotNull().WithMessage("Description cannot be empty!");
        }
    }
}
