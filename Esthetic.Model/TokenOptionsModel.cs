using MakeEat.Core.Contracts.Data;

namespace MakeEat.Model
{
    public class TokenOptionsModel : IDataModel
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
