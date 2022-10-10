using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user=>user.username).NotEmpty();
        }
    }
}


public class User
{
    public int Id { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string username { get; set; }
    public string Address { get; set; }
}