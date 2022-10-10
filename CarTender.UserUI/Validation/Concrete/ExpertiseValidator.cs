using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class ExpertiseValidator : AbstractValidator<ExpertiseDTO>
    {
        public ExpertiseValidator()
        {
            RuleFor(dto => dto.ExpertiseName).NotEmpty();
            RuleFor(dto => dto.AddressInformationID).NotEmpty();
            RuleFor(dto => dto.Latitude).NotEmpty();
            RuleFor(dto => dto.Longitude).NotEmpty();
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
        }
    }
}