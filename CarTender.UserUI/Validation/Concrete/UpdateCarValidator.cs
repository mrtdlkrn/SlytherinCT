using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class UpdateCarValidator : AbstractValidator<UpdateCarDTO>
    {
        public UpdateCarValidator()
        {
            RuleFor(dto => dto.Marka).NotEmpty();
            RuleFor(dto => dto.Model).NotEmpty();
            RuleFor(dto => dto.BodyType).NotEmpty();
            RuleFor(dto => dto.FuelType).NotEmpty();
            RuleFor(dto => dto.Year).NotEmpty();
            RuleFor(dto => dto.MyProperty).NotEmpty();
        }
    }
}