using CarTender.FluentValidation.DTO.AdminDTO.Car;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.AdminVAL.Car
{
    public class CarComissionVAL : AbstractValidator<CarComissionDTO>
    {
        public CarComissionVAL()
        {
            #region CarComissionModel

            #region PlateName

            RuleFor(x => x.CarPlate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen aracın plakasını giriniz.")
                .MinimumLength(2).WithMessage("Plaka alanı 2 karakterden küçük olamaz.")
                .MaximumLength(10).WithMessage("Plaka alanı 10 karakterden büyük olamaz.");

            #endregion

            #region ComissionPrice

            RuleFor(x => x.CommissionPrice)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty().WithMessage("Lütfen komisyon ücreti giriniz.")
              .GreaterThan(0).WithMessage("Komisyon ücreti 0 olamaz.");

            #endregion

            #region Info

            RuleFor(x => x.Info)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Açıklama alanı 10 karakterden küçük olamaz.")
                .MaximumLength(250).WithMessage("Açıklama alanı 250 karakterden büyük olamaz.");

            #endregion

            #region MinPrice

            RuleFor(x => x.MinPrice)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty().WithMessage("Lütfen minimum tutar giriniz.")
              .GreaterThan(0).WithMessage("Minimum tutar 0 olamaz.");

            #endregion

            #region MaxPrice

            RuleFor(x => x.MaxPrice)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty().WithMessage("Lütfen maksimum tutar giriniz.")
              .GreaterThan(0).WithMessage("Maksimum tutar 0 olamaz.");

            #endregion

            #endregion
        }
    }
}
