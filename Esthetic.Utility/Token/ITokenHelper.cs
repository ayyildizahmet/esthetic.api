using System.Collections.Generic;
using Esthetic.Domain;
using Esthetic.Model;

namespace Esthetic.Utility.Token
{
    public interface ITokenHelper
    {
        AccessTokenModel CreateToken(UserLoginResponseModel user, List<OperationClaim> operationClaims);
    }
}
