using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class UserLoginValidator : AbstractValidator<UserLoginDTO>
    {
        public UserLoginValidator()
        {
            RuleFor(user => user.Email).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(user => user.Password).NotEmpty().MinimumLength(2).MaximumLength(30);
        }
    }
}