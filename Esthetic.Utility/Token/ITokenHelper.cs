using System.Collections.Generic;
using MakeEat.Domain;
using MakeEat.Model;

namespace MakeEat.Utility.Token
{
    public interface ITokenHelper
    {
        AccessTokenModel CreateToken(UserLoginResponseModel user, List<OperationClaim> operationClaims);
    }
}
