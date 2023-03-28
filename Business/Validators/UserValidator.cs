using DataAccess.Entities;
using FluentValidation;

namespace Business.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName).NotNull().Length(1, 30);
            RuleFor(x => x.LastName).NotNull().Length(1, 30);
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.PhoneNumber).NotNull().MaximumLength(10);
        }
    }
}