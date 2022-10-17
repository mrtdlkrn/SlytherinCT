using CarTender.FluentValidation.DTO.AdminDTO.Register;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.AdminVAL.Register
{
    public class RegisterVAL : AbstractValidator<RegisterDTO>
    {
        public RegisterVAL()
        {
            #region FirstName

            RuleFor(x => x.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen isim giriniz.")
                .MinimumLength(2).WithMessage("İsim alanı en az 2 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("İsim alanı en çok 50 karakter olabilir.");

            #endregion

            #region LastName

            RuleFor(x => x.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen soyisim giriniz.")
                .MinimumLength(2).WithMessage("Soyisim alanı en az 2 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Soyisim alanı en çok 50 karakter olabilir.");

            #endregion

            #region Email

            RuleFor(x => x.Email)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
               .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
               .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");

            #endregion

            #region Password

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

            #region RePassword

            RuleFor(x => x.RePassword)
             .Cascade(CascadeMode.StopOnFirstFailure)
             .NotEmpty().WithMessage("Şifre tekrar alanı boş bırakılamaz.")
             .MinimumLength(8).WithMessage("Şifre tekrarı 8 karakterden küçük olamaz.")
             .MaximumLength(8).WithMessage("Şifre tekrarı karakterden büyük olamaz.")
             .Matches(@"[A-Z]+").WithMessage("Şire tekrarı en az bir büyük karakter olmalıdır.")
                 .Matches(@"[a-z]+").WithMessage("Şifre tekrarı en az bir küçük karakter olmalıdır.")
                 .Matches(@"[0-9]+").WithMessage("Şifre tekrarı az biri rakam olmalıdır.")
                 .Matches(@"[\!\?\*\.]+").WithMessage("Şifre tekrarı en az bir özel karakter olmalıdır(!? *.).")
                 .Equal(x => x.Password).WithMessage("Şifre tekrarı şifre ile uyuşmuyor.");

            #endregion
        }
    }
}
