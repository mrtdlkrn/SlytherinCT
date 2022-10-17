using CT.Entities.Entities;
using System.Collections.Generic;

namespace CarTender.Core.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
