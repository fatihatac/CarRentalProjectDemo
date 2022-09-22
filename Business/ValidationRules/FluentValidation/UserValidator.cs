using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Email).NotEmpty();
            RuleFor(c=>c.FirstName).NotEmpty();
            RuleFor(c=>c.LastName).NotEmpty();
            RuleFor(c=>c.Password).NotEmpty();
            RuleFor(c => c.Password).MinimumLength(4);
            //RuleFor(c => c.Password).Must(PasswordContent);
        }
    }
}
