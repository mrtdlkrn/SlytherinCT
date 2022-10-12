using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class CreateNewBidValidator : AbstractValidator<CreateNewBidDTO>
    {
        public CreateNewBidValidator()
        {
            RuleFor(dto => dto.BidName).NotEmpty();
            RuleFor(dto => dto.CustomerType).NotEmpty();
            RuleFor(dto => dto.CompanyName).NotEmpty();
            RuleFor(dto => dto.Statu).NotEmpty(); 
            RuleFor(dto => dto.BidStartDate).NotEmpty();
            RuleFor(dto => dto.BidStartTime).NotEmpty();
            RuleFor(dto => dto.BidEndDate).NotEmpty();
            RuleFor(dto => dto.BidEndTime).NotEmpty();
        }
    }
}