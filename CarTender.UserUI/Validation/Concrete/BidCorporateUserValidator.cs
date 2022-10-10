using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class BidCorporateUserValidator : AbstractValidator<BidCorporateUserDTO>
    {
        public BidCorporateUserValidator()
        {
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
            RuleFor(dto => dto.ModifiedBy).NotEmpty();
            RuleFor(dto => dto.ModifiedDate).NotEmpty();
        }
    }
}