using Entity.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Validation.Concrete
{
    public class TokenValidator : AbstractValidator<TokenDTO>
    {
        public TokenValidator()
        {
            RuleFor(token => token.Token).NotEmpty();
            RuleFor(token => token.ExpireTime).NotEmpty();
        }
    }
}
