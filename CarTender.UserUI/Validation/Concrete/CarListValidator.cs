using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class CarListValidator : AbstractValidator<CarListDTO>
    {
        public CarListValidator()
        {
            RuleFor(dto => dto.CarID).NotEmpty();
            RuleFor(dto => dto.CarBrand).NotEmpty();
            RuleFor(dto => dto.CarModel).NotEmpty();
            RuleFor(dto => dto.IsCorporate).NotEmpty();
            RuleFor(dto => dto.Status).NotEmpty();
            RuleFor(dto => dto.CreatedBy).NotEmpty();
            RuleFor(dto => dto.CreatedDate).NotEmpty();
            RuleFor(dto => dto.Price).NotEmpty();
        }
    }
}