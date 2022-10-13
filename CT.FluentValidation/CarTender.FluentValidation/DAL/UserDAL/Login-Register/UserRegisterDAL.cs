using CarTender.FluentValidation.DTO.UserDTO.Login_Register;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DAL.UserDAL.Login_Register
{
    public class UserRegisterDAL : AbstractValidator<UserRegisterDTO>
    {
        public UserRegisterDAL()
        {
            #region User Username Register

            RuleFor(x => x.Username)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(5).WithMessage("{PropertyName} alanı 5 karakterden küçük olamaz.")
                .MaximumLength(20).WithMessage("{PropertyName} alanı 20 karakterden büyük olamaz.");

            #endregion

            #region User Password Register

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

            #region User Name Surname Register

            RuleFor(x => x.NameSurname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(5).WithMessage("{PropertyName} alanı 5 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");

            #endregion

            #region User Phone Register

            RuleFor(x => x.Phone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
                .MaximumLength(20).WithMessage("{PropertyName} alanı 20 karakterden büyük olamaz.");
            #endregion

            #region User Email Register

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");

            #endregion

            #region User Address Register

            RuleFor(x => x.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");

            #endregion

            #region User Information Register

            RuleFor(x => x.Information)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");

            #endregion
        }
    }
}
