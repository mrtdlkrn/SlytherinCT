using CarTender.FluentValidation.DTO.AdminDTO.Car;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.CombineVAL.Car
{
    public class BrandVAL : AbstractValidator<CarBrandDTO>
    {
        public BrandVAL()
        {

            #region VehicleBrand

            RuleFor(x => x.VehicleBrand)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen aracın markasını giriniz.")
                .MinimumLength(2).WithMessage("Aracın markası 2 karakterden az olamaz.")
                .MaximumLength(50).WithMessage("Aracın markası 50 karakterden fazla olamaz.");

            #endregion


        }
    }
}
