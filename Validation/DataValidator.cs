using FluentValidation;
using Microsoft.AspNetCore.Identity;
using TaskBySibers.Models;

namespace TaskBySibers.Validation
{
    public class DataValidator<T> : AbstractValidator<T>
    {
        private readonly UserManager<IdentityUser> _userManager;

        public DataValidator()
        {

            // Проверяем тип T и добавляем соответствующие правила валидации
            if (typeof(T) == typeof(Project))
            {
                RuleFor(x => (x as Project).Name)
                    .NotEmpty().WithMessage("Property name is required.")
                    .MaximumLength(20).WithMessage("Name length must be less than or equal to 20 characters.");

                RuleFor(x => (x as Project).CustomerCompanyName)
                    .MaximumLength(20).WithMessage("Customer company name length must be less than or equal to 20 characters.");

                RuleFor(x => (x as Project).PrformerCompany)
                    .MaximumLength(20).WithMessage("Performer company name length must be less than or equal to 20 characters.");

                RuleFor(x => (x as Project).ProjectPriority)
                    .InclusiveBetween(1, 10).WithMessage("Project priority must be between 1 and 10.");
            }
            else if (typeof(T) == typeof(Employee))
            {
                RuleFor(x => (x as Employee).Name)
                    .NotEmpty().WithMessage("Name is required.")
                    .Matches(@"^[А-ЯЁ][а-яё]*$").WithMessage("Name must contain only Russian letters and start with an uppercase letter.")
                    .MaximumLength(20).WithMessage("Name length must be less than or equal to 20 characters.");

                RuleFor(x => (x as Employee).LastName)
                    .NotEmpty().WithMessage("Last name is required.")
                    .Matches(@"^[А-ЯЁ][а-яё]*$").WithMessage("Last name must contain only Russian letters and start with an uppercase letter.")
                    .MaximumLength(20).WithMessage("Last name length must be less than or equal to 20 characters.");

                RuleFor(x => (x as Employee).SurName)
                    .Matches(@"^[А-ЯЁ][а-яё]*$").WithMessage("Surname must contain only Russian letters and start with an uppercase letter.")
                    .MaximumLength(20).WithMessage("Surname length must be less than or equal to 20 characters.");

                RuleFor(x => (x as Employee).Email)
                    .NotEmpty().WithMessage("Email is required.")
                    .Matches(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$").WithMessage("Invalid email address format.");
            }
        }
    }
}
