using CarTender.FluentValidation.DTO.AdminDTO.Car;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.AdminVAL.Car
{
    public class CarSaleHistoryVAL : AbstractValidator<CarSaleHistoryDTO>
    {
        public CarSaleHistoryVAL()
        {
            #region CarSaleHistroyModel

            #region CarPlate

            RuleFor(x => x.CarPlate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen aracın plakasını giriniz.")
                .MinimumLength(2).WithMessage("Plaka alanı 2 karakterden küçük olamaz.")
                .MaximumLength(10).WithMessage("Plaka alanı 10 karakterden büyük olamaz.");

            #endregion

            #region BuyerMail

            RuleFor(x => x.BuyerMail)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Alıcı Email alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Alıcı Email alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("Alıcı Email alanı 100 karakterden büyük olamaz.");

            #endregion

            #region SellerMail

            RuleFor(x => x.SellerMail)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Satıcı Email alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Satıcı Email alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("Satıcı Email alanı 100 karakterden büyük olamaz.");

            #endregion

            #region ComissionPrice

            RuleFor(x => x.CommissionPrice)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .GreaterThan(0).WithMessage("Komisyon fiyatı 0 olamaz.");

            #endregion

            #endregion
        }
    }
}
