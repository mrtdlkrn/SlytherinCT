using CarTender.FluentValidation.DTO.AdminDTO.Login;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.AdminVAL.Login
{
    public class AdminLoginVAL : AbstractValidator<AdminLoginDTO>
    {
        public AdminLoginVAL()
        {
            #region Admin Email Login

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");

            #endregion

            #region Admin Password Login

            RuleFor(x => x.Password)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.")
            .MinimumLength(8).WithMessage("Şifreniz 8 karakterden küçük olamaz.")
            .MaximumLength(8).WithMessage("Şifreniz 8 karakterden büyük olamaz.")
            .Matches(@"[A-Z]+").WithMessage("Şirenizde en az bir büyük karakter olmalıdır.")
                .Matches(@"[a-z]+").WithMessage("Şifrenizde en az bir küçük karakter olmalıdır.")
                .Matches(@"[0-9]+").WithMessage("Şifrenizde en az biri rakam olmalıdır.")
                .Matches(@"[\!\?\*\.]+").WithMessage("Şifrenizde en az bir özel karakter olmalıdır(!? *.).");

            #endregion
        }
    }
}
