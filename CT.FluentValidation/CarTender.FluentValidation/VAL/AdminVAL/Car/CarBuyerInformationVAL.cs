using CarTender.FluentValidation.DTO.AdminDTO.Car;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.VAL.AdminVAL.Car
{
    public class CarBuyerInformationVAL : AbstractValidator<CarBuyerInformationDTO>
    {
        public CarBuyerInformationVAL()
        {
            #region CarBuyerInformationModel

            #region PlateName

            RuleFor(x => x.CarPlate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen aracın plakasını giriniz.")
                .MinimumLength(2).WithMessage("Plaka alanı 2 karakterden küçük olamaz.")
                .MaximumLength(10).WithMessage("Plaka alanı 10 karakterden büyük olamaz.");

            #endregion

            #region BuyerMail

            RuleFor(x => x.BuyerMail)
                   .Cascade(CascadeMode.StopOnFirstFailure)
                   .NotEmpty().WithMessage("Satıcı Email alanı boş bırakılamaz.")
                   .MinimumLength(10).WithMessage("Satıcı Email alanı 10 karakterden küçük olamaz.")
                   .MaximumLength(100).WithMessage("Satıcı Email alanı 100 karakterden büyük olamaz.");

            #endregion

            #region Info

            RuleFor(x => x.Info)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Açıklama alanı 10 karakterden küçük olamaz.")
                .MaximumLength(250).WithMessage("Açıklama alanı 250 karakterden büyük olamaz.");

            #endregion

            #region MinPrice

            RuleFor(x => x.Price)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty().WithMessage("Lütfen satış tutarı tutar giriniz.")
              .GreaterThan(0).WithMessage("Satış tutarı tutar 0 olamaz.");

            #endregion

            #region BuyerMail

            RuleFor(x => x.CreatedEmail)
                   .Cascade(CascadeMode.StopOnFirstFailure)
                   .NotEmpty().WithMessage("Alıcı Email alanı boş bırakılamaz.")
                   .MinimumLength(10).WithMessage("Alıcı Email alanı 10 karakterden küçük olamaz.")
                   .MaximumLength(100).WithMessage("Alıcı Email alanı 100 karakterden büyük olamaz.");

            #endregion

            #endregion
        }
    }
}
