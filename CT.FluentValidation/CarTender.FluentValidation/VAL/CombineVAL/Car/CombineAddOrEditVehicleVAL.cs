using CarTender.FluentValidation.DTO.CombineDTO.Car;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.CombineVAL.Car
{
    public class CombineAddOrEditVehicleVAL : AbstractValidator<CombineAddOrEditVehicleDTO>
    {
        public CombineAddOrEditVehicleVAL()
        {
            #region Admin and User Add Vehicle Page
            //Combined tier is for public domain fields on both admin side and User side

            #region Vehicle Price

            RuleFor(x => x.Price)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen araç fiyatı giriniz.")
                .GreaterThan(0).WithMessage("Araç fiyatı 0 TL olamaz.")
                .Must(x => x > 0 && x < 1000000000).WithMessage("Araç fiyatı girilebilecek miktar aralığında değil.(0-1.000.000.000)");

            #endregion

            #region KM

            RuleFor(x => x.KM)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Araç kilometre bilgisi boş bırakılamaz.")
                .Must(x => x > 0 && x < 1000000).WithMessage("Araç fiyatı girilebilecek miktar aralığında değil.(0-1.000.000)");

            #endregion

            #region Explanation

            RuleFor(x => x.Explanation)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen açıklama giriniz.")
                .MinimumLength(10).WithMessage("10 karakterden az açıklama giremezsiniz.")
                .MaximumLength(250).WithMessage("250 karakterden fazla açıklama girdiniz.");

            #endregion

            #region PhotoPaht1

            RuleFor(x => x.PhotoPath1)
                .NotEmpty().WithMessage("Lütfen Araç Fotoğrafı Giriniz.");

            #endregion

            #region PhotoPaht2

            RuleFor(x => x.PhotoPath2)
                .NotEmpty().WithMessage("Lütfen Araç Fotoğrafı Giriniz.");

            #endregion

            #region PhotoPaht3

            RuleFor(x => x.PhotoPath3)
                .NotEmpty().WithMessage("Lütfen Araç Fotoğrafı Giriniz.");

            #endregion

            #region PhotoPaht4

            RuleFor(x => x.PhotoPath4)
                .NotEmpty().WithMessage("Lütfen Araç Fotoğrafı Giriniz.");

            #endregion

            #region PhotoPaht5

            RuleFor(x => x.PhotoPath5)
                .NotEmpty().WithMessage("Lütfen Araç Fotoğrafı Giriniz.");

            #endregion

            #endregion

        }
    }
}
