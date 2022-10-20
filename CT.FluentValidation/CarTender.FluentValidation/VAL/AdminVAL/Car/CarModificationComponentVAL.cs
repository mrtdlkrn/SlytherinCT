using CarTender.FluentValidation.DTO.AdminDTO.Car;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.AdminVAL.Car
{
    public class CarModificationComponentVAL : AbstractValidator<CarModificationComponentDTO>
    {
        public CarModificationComponentVAL()
        {
            #region ModificationModel

            RuleFor(x => x.ComponentName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen aracın modifiye parçalarını giriniz.")
                .MinimumLength(2).WithMessage("Girmeniz gerekenden az karakter girdiniz.")
                .MaximumLength(10).WithMessage("Girmeniz gerekenden fazla karakter girdiniz.");

            #endregion
        }
    }
}
