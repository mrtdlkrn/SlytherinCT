using CarTender.FluentValidation.DTO.AdminDTO.Tramer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.VAL.AdminVAL.Tramer
{
    public class AddTramerComponentVAL : AbstractValidator<AddTramerComponentDTO>
    {
        public AddTramerComponentVAL()
        {
            RuleFor(x => x.Name)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty().WithMessage("Lütfen bileşen adı giriniz.")
              .MinimumLength(2).WithMessage("Bileşen adı 2 karakterden az olamaz.")
              .MaximumLength(50).WithMessage("Bileşen adı 50 karakterden fazla olamaz.");


            RuleFor(x => x.CreatorsEmail)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Kayıt eden kişi email alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Kayıt eden kişi email alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("Kayıt eden kişi email alanı 100 karakterden büyük olamaz.");
        }
    }
}
