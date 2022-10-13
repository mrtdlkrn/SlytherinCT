using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DAL.CombineDAL.Bid
{
    public class CombineBidListDAL : AbstractValidator<CombineBidDTO>
    {
        public CombineBidListDAL()
        {
            #region Admin and User ListBidName Bid Page

            RuleFor(x => x.BidName)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen İhale Adı Giriniz.")
               .MaximumLength(50).WithMessage("50 Fazla Karakter Girdiniz.");

            #endregion
        }
    }
}
