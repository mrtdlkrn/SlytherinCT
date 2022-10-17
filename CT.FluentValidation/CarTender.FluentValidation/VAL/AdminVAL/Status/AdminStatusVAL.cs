using CarTender.FluentValidation.DTO.AdminDTO.Status;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.AdminVAL.Status
{
    public class AdminStatusVAL : AbstractValidator<AdminStatusDTO>
    {
        public AdminStatusVAL()
        {
            RuleFor(x => x.StatusName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Statü Giriniz.")
                .MaximumLength(50).WithMessage("50 Karakterden Fazla Girdiniz.");

        }
    }
}
