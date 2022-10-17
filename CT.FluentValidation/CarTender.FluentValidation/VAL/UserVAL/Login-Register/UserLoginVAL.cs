using CarTender.FluentValidation.DTO.UserDTO.Login_Register;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.UserVAL.Login_Register
{
    public class UserLoginVAL : AbstractValidator<UserLoginDTO>
    {
        public UserLoginVAL()
        {
            #region User Username Login

            RuleFor(x => x.Username)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Kullanıcı adı alanı boş bırakılamaz.")
                .MinimumLength(5).WithMessage("Kullanıcı adı alanı 5 karakterden küçük olamaz.")
                .MaximumLength(20).WithMessage("Kullanıcı adı alanı 20 karakterden büyük olamaz.");

            #endregion

            #region User Password Login

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
