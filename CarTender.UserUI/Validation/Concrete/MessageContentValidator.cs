using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using FluentValidation;

namespace Common.Validation.Concrete
{
    public class MessageContentValidator : AbstractValidator<MessageContentDTO>
    {
        public MessageContentValidator()
        {
            RuleFor(dto => dto.ContentText).NotEmpty();
            RuleFor(dto => dto.IsActive).NotEmpty();
            RuleFor(dto => dto.Version).NotEmpty();
        }
    }
}