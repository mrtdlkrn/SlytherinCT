using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DAL.CombineDAL.Bid
{
    public class CombineBidUserOfferDAL : AbstractValidator<CombineBidUserOfferDTO>
    {
        public CombineBidUserOfferDAL()
        {
            #region Admin and User Bid User Offer Detail

            RuleFor(x => x.Price)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen Fiyat Giriniz.");

            #endregion
        }
    }
}
