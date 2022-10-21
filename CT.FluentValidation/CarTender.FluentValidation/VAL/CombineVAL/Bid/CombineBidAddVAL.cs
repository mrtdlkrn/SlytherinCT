using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;
using Microsoft.AspNetCore.Localization;
using System;

namespace CarTender.FluentValidation.VAL.CombineVAL.Bid
{
    public class CombineBidAddVAL : AbstractValidator<CombineBidDTO>
    {
        public CombineBidAddVAL()
        {
            #region Admin and User AddBidName Bid Page

            RuleFor(x => x.BidName)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen İhale Adı Giriniz.")
               .MinimumLength(2).WithMessage("İhale adı 2 karakterden az olamaz.")
               .MaximumLength(50).WithMessage("İhale adı 50 karakterden fazla olamaz.");

            #endregion

            //#region Admin and User AddBidStartTime Bid Page

            RuleFor(x => x.BidStartTime)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .Must(BeValidDate).WithMessage("Geçmişe yönelik ihale oluşturamazsınız.");

            //#endregion

            //#region Admin and User AddFinishStartTime Bid Page

            //RuleFor(x => x.BidFinishTime)
            //   .Cascade(CascadeMode.StopOnFirstFailure)
            //   .NotEmpty().WithMessage("Lütfen İhale Bitiş Saatini Giriniz.")
            //   .MaximumLength(6).WithMessage("6 Karakter Fazla Girdiniz.");

            //#endregion

        }
        protected bool BeValidDate(DateTime date)
        {
            int currenctDate = DateTime.Now.Day;
            int dobDay = date.Day;

            if (dobDay >= currenctDate)
            {
                return true;
            }

            return false;
        }
    }
}
