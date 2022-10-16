using CarTender.FluentValidation.DTO.AdminDTO.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DAL.AdminDAL.User
{
    public class AdminUserVAL : AbstractValidator<AdminUserDTO>
    {
        public AdminUserVAL()
        {
            RuleFor(x => x.UserName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Kullanıcı Adı Boş Bırakılamaz.")
                .MinimumLength(4).WithMessage("Kullanıcı Adı 4 Karakterden Küçük Olamaz.")
                .MaximumLength(60).WithMessage("Kullanıcı Adı 60 Karakterden Fazla Olamaz.");

            RuleFor(x=>x.CustomerName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Müşteri Adı Boş Bırakılamaz.")
                .MinimumLength(4).WithMessage("Müşteri Adı 4 Karakterden Küçük Olamaz.")
                .MaximumLength(60).WithMessage("Müşteri Adı 60 Karakterden Fazla Olamaz.");

            RuleFor(x => x.Phone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Telefon Alanı Boş Bırakılamaz.")
                .MinimumLength(13).WithMessage("Telefon 13 Karakterden Küçük Olamaz.")
                .MaximumLength(13).WithMessage("Telefon 13 Karakterden Fazla Olamaz.");

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");

            RuleFor(x => x.Information)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Açıklama Yapnız.")
                .MaximumLength(250).WithMessage("Açıklama alanı 250 karakterden büyük olamaz.");
        }
    }
}
