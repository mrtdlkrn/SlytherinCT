using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class BidOfferDetailValidator : AbstractValidator<BidOfferDetailDTO>
    {
        public BidOfferDetailValidator()
        {
            RuleFor(dto => dto.BidUserOfferID).NotEmpty();
            RuleFor(dto => dto.Price).NotEmpty();
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
        }
    }
}