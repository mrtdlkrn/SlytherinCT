using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.CombineVAL.Bid
{
    public class CombineBidUserOfferVAL : AbstractValidator<CombineBidUserOfferDTO>
    {
        public CombineBidUserOfferVAL()
        {
            #region Admin and User Bid User Offer Detail

            RuleFor(x => x.Price)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen Fiyat Giriniz.");

            #endregion
        }
    }
}
