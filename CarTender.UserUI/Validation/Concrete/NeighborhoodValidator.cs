using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class NeighborhoodValidator : AbstractValidator<NeighborhoodDTO>
    {
        public NeighborhoodValidator()
        {
            RuleFor(dto => dto.DistrictID).NotEmpty();
            RuleFor(dto => dto.NeighborhoodName).NotEmpty();
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
        }
    }
}