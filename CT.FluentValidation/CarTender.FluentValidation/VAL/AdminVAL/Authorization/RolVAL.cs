using CarTender.FluentValidation.DTO.AdminDTO.Authorization;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.VAL.AdminVAL.Authorization
{
    public class RolVAL : AbstractValidator<AuthorizationDTO>
    {
        public RolVAL()
        {

            RuleFor(x => x.RolName)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty().WithMessage("Lütfen rol adı giriniz.")
              .MinimumLength(2).WithMessage("Rol adı 2 karakterden az olamaz.")
              .MaximumLength(50).WithMessage("Rol adı 50 karakterden fazla olamaz.");
        }
    }
}
