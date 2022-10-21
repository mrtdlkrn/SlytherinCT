using CarTender.FluentValidation.DTO.AdminDTO.Authorization;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.VAL.AdminVAL.Authorization
{
    public class AuthorizationVAL : AbstractValidator<AuthorizationDTO>
    {
        public AuthorizationVAL()
        {
            RuleFor(x => x.AuthorizationName)
             .Cascade(CascadeMode.StopOnFirstFailure)
             .NotEmpty().WithMessage("Lütfen yetki adı giriniz.")
             .MinimumLength(2).WithMessage("Yeki adı 2 karakterden az olamaz.")
             .MaximumLength(10).WithMessage("Yetki adı 10 karakterden fazla olamaz.");
        }
    }
}
