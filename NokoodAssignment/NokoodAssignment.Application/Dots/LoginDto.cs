using FluentValidation;

namespace NokoodAssignment.Application.Dots
{
    public class LoginDto
    {
        public string UserNameOrEmailAddress { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(u => u.UserNameOrEmailAddress)
              .NotNull()
              .NotEmpty()
              .EmailAddress();

            RuleFor(u => u.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(10);
        }
    }
}
