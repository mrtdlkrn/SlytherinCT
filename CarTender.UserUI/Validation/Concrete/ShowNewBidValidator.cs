using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class ShowNewBidValidator : AbstractValidator<ShowNewBidDTO>
    {
        public ShowNewBidValidator()
        {
            RuleFor(dto => dto.CarList).NotEmpty();
            RuleFor(dto => dto.Bids).NotEmpty();
        }
    }
}