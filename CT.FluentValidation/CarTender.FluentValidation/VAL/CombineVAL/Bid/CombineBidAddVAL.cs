using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DAL.CombineDAL.Bid
{
    public class CombineBidAddVAL : AbstractValidator<CombineBidDTO>
    {
        public CombineBidAddVAL()
        {
            #region Admin and User AddBidName Bid Page

            RuleFor(x => x.BidName)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen İhale Adı Giriniz.")
               .MaximumLength(50).WithMessage("50 Fazla Karakter Girdiniz.");

            #endregion

            #region Admin and User AddBidStartTime Bid Page

            RuleFor(x => x.BidStartTime)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen İhale Başlangıç Saatini Giriniz.")
               .MaximumLength(6).WithMessage("6 Karakter Fazla Girdiniz.");

            #endregion

            #region Admin and User AddFinishStartTime Bid Page

            RuleFor(x => x.BidFinishTime)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen İhale Bitiş Saatini Giriniz.")
               .MaximumLength(6).WithMessage("6 Karakter Fazla Girdiniz.");

            #endregion
        }
    }
}
