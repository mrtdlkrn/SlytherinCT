using CarTender.FluentValidation.DTO.CombineDTO.Car;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.VAL.CombineVAL.Car
{
    public class CombineAddOrEditVehicleVAL : AbstractValidator<CombineAddOrEditVehicleDTO>
    {
        public CombineAddOrEditVehicleVAL()
        {
            #region Admin and User Add Vehicle Page
            //Combined tier is for public domain fields on both admin side and User side

            #region Vehicle Price

            RuleFor(x => x.VehiclePrice)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Araç Fiyatı Giriniz.")
                .GreaterThan(0).WithMessage("Araç Fiyatı 0 TL Olamaz.");

            #endregion

            #region KM

            RuleFor(x => x.KM)
                .NotEmpty().WithMessage("Araç Kilometre Bilgisi Boş Bırakılamaz.");

            #endregion

            #region Explanation

            RuleFor(x => x.Explanation)
                .NotEmpty().WithMessage("Lütfen Açıklama Giriniz.")
                .MaximumLength(250).WithMessage("250 Karakterden Fazla Girdiniz.");

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

            #region VehicleBrand

            RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.VehicleBrand)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Aracın Markasını Giriniz.")
                .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            #endregion

            #region VehicleModel

            RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.VehicleModel)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Aracın Modelini Giriniz.")
                .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            #endregion

            #region BodyType

            RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.BodyType)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Aracın Kasa Tipini Giriniz.")
                .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            #endregion

            #region FuelType

            RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.FuelType)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Aracın Yakıt Tipini Giriniz.")
                .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            #endregion

            #region GearType

            RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.GearType)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Aracın Vitis Tipini Giriniz.")
                .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            #endregion

            #region Color

            RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.FuelType)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Aracın Rengini Giriniz.")
                .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            #endregion

            #region Hardware

            RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.Hardware)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Aracın Donanımını Giriniz.")
                .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            #endregion

            #region Version

            RuleFor(x => x.CombineAddOrEditVehicleDetailDTO.Version)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Aracın Versiyonunu Giriniz.")
                .MaximumLength(50).WithMessage("Girmeniz Gerekenden Fazla Karakter Girdiniz.");

            #endregion

            #endregion

        }
    }
}
