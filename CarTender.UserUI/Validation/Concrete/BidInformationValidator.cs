using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class BidInformationValidator : AbstractValidator<BidInformationDTO>
    {
        public BidInformationValidator()
        {
            RuleFor(dto => dto.BidName).NotEmpty();
            RuleFor(dto => dto.IsCorporate).NotEmpty();
            RuleFor(dto => dto.IsApproved).NotEmpty();
            RuleFor(dto => dto.FinishedDate).NotEmpty();
            RuleFor(dto => dto.ModifiedDate).NotEmpty();
            RuleFor(dto => dto.ApprovedBy).NotEmpty();
            RuleFor(dto => dto.FinishedBy).NotEmpty();
            RuleFor(dto => dto.CreatedDate).NotEmpty();
            RuleFor(dto => dto.ModifiedBy).NotEmpty();
            RuleFor(dto => dto.UserID).NotEmpty();
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
            RuleFor(dto => dto.AddressInformationID).NotEmpty();
        }
    }
}