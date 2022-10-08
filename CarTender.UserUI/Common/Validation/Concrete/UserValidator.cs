using Common.Validation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class UserValidator : Abstract.AbstractValidator<User>
    {
        public UserValidator()
        {
            //RuleFor(user=>user.username).NotEmpty();
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