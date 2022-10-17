using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.VAL.CombineVAL.Bid
{
    public class CombineBidListVAL : AbstractValidator<CombineBidDTO>
    {
        public CombineBidListVAL()
        {
            #region Admin and User ListBidName Bid Page

            RuleFor(x => x.BidName)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen İhale Adı Giriniz.")
               .MaximumLength(50).WithMessage("50 Fazla Karakter Girdiniz.");

            #endregion
        }
    }
}
