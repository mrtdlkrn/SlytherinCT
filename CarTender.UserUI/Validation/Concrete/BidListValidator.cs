using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class BidListValidator : AbstractValidator<BidListDTO>
    {
        public BidListValidator()
        {
            RuleFor(dto => dto.CarList).NotEmpty();
            RuleFor(dto => dto.CreateNewBid).NotEmpty();
        }
    }
}