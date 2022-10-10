using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class BidStatusHistoryValidator : AbstractValidator<BidStatusHistoryDTO>
    {
        public BidStatusHistoryValidator()
        {
            RuleFor(dto => dto.Information).NotEmpty();
            RuleFor(dto => dto.ModifiedDate).NotEmpty();
            RuleFor(dto => dto.ModifiedBy).NotEmpty();
            RuleFor(dto => dto.BidID).NotEmpty();
            RuleFor(dto => dto.StatuID).NotEmpty();
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
        }
    }
}