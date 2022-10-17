using CarTender.FluentValidation.DTO.AdminDTO.Status;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DAL.AdminDAL.Status
{
    public class AdminStatusVAL : AbstractValidator<AdminStatusDTO>
    {
        public AdminStatusVAL()
        {
            RuleFor(x => x.StatusName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Lütfen Statü Giriniz.")
                .MaximumLength(50).WithMessage("50 Karakterden Fazla Girdiniz.");
                
        }
    }
}
