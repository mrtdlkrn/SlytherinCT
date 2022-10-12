using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class BidUserOfferValidator : AbstractValidator<BidUserOfferDTO>
    {
        public BidUserOfferValidator()
        {
            RuleFor(dto => dto.BidCorporateUserID).NotEmpty();
            RuleFor(dto => dto.Price).NotEmpty();
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
        }
    }
}