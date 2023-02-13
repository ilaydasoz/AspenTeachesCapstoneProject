using System;
using DTOLayer.DTOs.InstructorDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class InstructorAddValidator : AbstractValidator<InstructorAddDTO>
    {
        public InstructorAddValidator()
        {
            // character restrictions
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name must be 3 characters at least!");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Surname must be 5 characters at least!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Title must be 5 characters at least!");

            //not empty
            RuleFor(x => x.Name).NotNull().WithMessage("Name cannot be empty!");
            RuleFor(x => x.Surname).NotNull().WithMessage("Surname cannot be empty!");
            RuleFor(x => x.GithubUrl).NotNull().WithMessage("Github url cannot be empty!");
            RuleFor(x => x.LinkedinUrl).NotNull().WithMessage("Linkedln url cannot be empty!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be empty!");
        }
    }
}
