using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.CombineVAL.Bid
{
    public class CombineBidOfferDetailVAL : AbstractValidator<CombineBidOfferDetailDTO>
    {
        public CombineBidOfferDetailVAL()
        {
            #region Admin and User Bid Offer Detail

            RuleFor(x => x.Price)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen Fiyat Giriniz.");

            #endregion
        }
    }
}
