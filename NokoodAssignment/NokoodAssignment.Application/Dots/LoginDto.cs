﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokoodAssignment.Application.Dots
{
    public class LoginDto
    {
        public string UserNameOrEmailAddress { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class LoginDtoValidator:AbstractValidator<LoginDto>
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
