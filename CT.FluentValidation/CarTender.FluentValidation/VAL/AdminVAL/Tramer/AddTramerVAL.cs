using CarTender.FluentValidation.DTO.AdminDTO.Tramer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.VAL.AdminVAL.Tramer
{
    public class AddTramerVAL : AbstractValidator<AddTramerDTO>
    {
        public AddTramerVAL()
        {
            RuleFor(x => x.CarPlate)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen araç plakası giriniz.")
               .MinimumLength(10).WithMessage("Lütfen doğru formatta araç plakası giriniz.")
               .MaximumLength(10).WithMessage("Lütfen doğru formatta araç plakası giriniz.");

            RuleFor(x => x.CreatedBy)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen kayıt eden kişi ismi giriniz.")
                .MinimumLength(2).WithMessage("Kayıt eden kişi adı 2 karakterden az giremez.")
                .MaximumLength(50).WithMessage("Kayıt eden kişi adı 50 karakterden fazla olamaz.");
        }
    }
}
