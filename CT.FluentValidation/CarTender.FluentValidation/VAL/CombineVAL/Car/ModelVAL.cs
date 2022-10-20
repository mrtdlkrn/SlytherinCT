using CarTender.FluentValidation.DTO.CombineDTO.Car;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.CombineVAL.Car
{
    public class ModelVAL : AbstractValidator<CombineAddOrEditVehicleDetailDTO>
    {
        public ModelVAL()
        {
            #region VehicleModel

            RuleFor(x => x.VehicleModel)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen aracın modelini giriniz.")
                .MinimumLength(2).WithMessage("Girmeniz gerekenden az karakter girdiniz.")
                .MaximumLength(50).WithMessage("Girmeniz gerekenden fazla karakter girdiniz.");

            #endregion
        }
    }
}
