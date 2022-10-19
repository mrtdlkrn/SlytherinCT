using CarTender.FluentValidation.DTO.AdminDTO.Car;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.AdminVAL.Car
{
    public class CarStatusHistoryVAL : AbstractValidator<CarStatusHistoryDTO>
    {
        public CarStatusHistoryVAL()
        {
            #region CarStatusHistoryModel

            #region PlateName

            RuleFor(x => x.PlateName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen aracın plakasını giriniz.")
                .MinimumLength(2).WithMessage("Plaka alanı 2 karakterden küçük olamaz.")
                .MaximumLength(10).WithMessage("Plaka alanı 10 karakterden büyük olamaz.");

            #endregion

            #region Information

            RuleFor(x => x.Information)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty().WithMessage("Lütfen açıklama giriniz.")
              .MinimumLength(2).WithMessage("Açıklama alanı 2 karakterden küçük olamaz.")
              .MaximumLength(250).WithMessage("Açıklama alanı 250 karakterden büyük olamaz.");

            #endregion

            #region CreatedEmail

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
