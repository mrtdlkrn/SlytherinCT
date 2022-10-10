using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class AddVehicleValidator : AbstractValidator<AddVehicleDTO>
    {
        public AddVehicleValidator()
        {
            RuleFor(dto => dto.PersonalCorporate).NotEmpty().WithMessage("Bireysel Kurumsal seçimi yapınız!!");
            RuleFor(dto => dto.CompanyName).NotEmpty().MinimumLength(2).WithMessage("Şirket Adı giriniz!!");
            RuleFor(dto => dto.Statu).NotEmpty();
            RuleFor(dto => dto.VehiclePrice).NotEmpty();
            RuleFor(dto => dto.VehicleBrand).NotEmpty();
            RuleFor(dto => dto.VehicleModel).NotEmpty();
            RuleFor(dto => dto.BodyType).NotEmpty();
            RuleFor(dto => dto.Year).NotEmpty();
            RuleFor(dto => dto.FuelType).NotEmpty();
            RuleFor(dto => dto.GearType).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
            RuleFor(dto => dto.KM).NotEmpty();
            RuleFor(dto => dto.Color).NotEmpty();
            RuleFor(dto => dto.Hardware).NotEmpty();
            RuleFor(dto => dto.PhotoPath1).NotEmpty();
            RuleFor(dto => dto.PhotoPath2).NotEmpty();
            RuleFor(dto => dto.PhotoPath3).NotEmpty();
            RuleFor(dto => dto.PhotoPath4).NotEmpty();
            RuleFor(dto => dto.PhotoPath5).NotEmpty();
            RuleFor(dto => dto.Explanation).NotEmpty();
        }
    }
}