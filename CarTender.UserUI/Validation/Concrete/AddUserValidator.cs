using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class AddUserValidator : AbstractValidator<AddUserDTO>
    {
        public AddUserValidator(AddUserDTO addUserDTO)
        {
            RuleFor(dto => dto.Name).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(dto => dto.Surname).NotEmpty().MinimumLength(2).MaximumLength(20);


            foreach(PropertyInfo p in addUserDTO.GetType().GetProperties())
            {
                if(p.PropertyType == typeof(string))
                {
                    
                }

            }
        }
    }
}