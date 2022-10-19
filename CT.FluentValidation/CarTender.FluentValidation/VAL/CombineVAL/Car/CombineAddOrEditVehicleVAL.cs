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
                .Must(x => x > 0 && x < 1000000000).WithMessage("Araç fiyatı girilebilecek miktar aralğında değil.(0-1.000.000.000)");

            #endregion

            #region KM

            RuleFor(x => x.KM)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Araç kilometre bilgisi boş bırakılamaz.")
                .Must(x => x > 0 && x < 1000000).WithMessage("Araç fiyatı girilebilecek miktar aralğında değil.(0-1.000.000)");

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

            //#region BodyType

            //RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.BodyType)
            //    .Cascade(CascadeMode.StopOnFirstFailure)
            //    .NotEmpty().WithMessage("Lütfen Aracın Kasa Tipini Giriniz.")
            //    .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            //#endregion

            //#region FuelType

            //RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.FuelType)
            //    .Cascade(CascadeMode.StopOnFirstFailure)
            //    .NotEmpty().WithMessage("Lütfen Aracın Yakıt Tipini Giriniz.")
            //    .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            //#endregion

            //#region GearType

            //RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.GearType)
            //    .Cascade(CascadeMode.StopOnFirstFailure)
            //    .NotEmpty().WithMessage("Lütfen Aracın Vitis Tipini Giriniz.")
            //    .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            //#endregion

            //#region Color

            //RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.Color)
            //    .Cascade(CascadeMode.StopOnFirstFailure)
            //    .NotEmpty().WithMessage("Lütfen Aracın Rengini Giriniz.")
            //    .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            //#endregion

            //#region Hardware

            //RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.Hardware)
            //    .Cascade(CascadeMode.StopOnFirstFailure)
            //    .NotEmpty().WithMessage("Lütfen Aracın Donanımını Giriniz.")
            //    .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            //#endregion

            //#region Version

            //RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.Version)
            //    .Cascade(CascadeMode.StopOnFirstFailure)
            //    .NotEmpty().WithMessage("Lütfen Aracın Versiyonunu Giriniz.")
            //    .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            //#endregion

            #endregion

        }
    }
}
