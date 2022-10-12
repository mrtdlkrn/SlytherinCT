using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class MessageValidator : AbstractValidator<MessageDTO>
    {
        public MessageValidator()
        {
            RuleFor(dto => dto.MessageContentID).NotEmpty();
            RuleFor(dto => dto.UserID).NotEmpty();
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
        }
    }
}