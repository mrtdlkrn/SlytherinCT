using CarTender.FluentValidation.DTO.AdminDTO.ForgotPassword;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.AdminVAL.ForgotPassword
{
    public class ForgotPasswordVAL : AbstractValidator<ForgotPasswordDTO>
    {
        public ForgotPasswordVAL()
        {
            #region Admin Email ForgotPassword

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");

            #endregion
        }
    }
}
