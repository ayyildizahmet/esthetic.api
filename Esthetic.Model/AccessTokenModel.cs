using System;
using Esthetic.Core.Contracts.Data;

namespace Esthetic.Model
{
    public class AccessTokenModel : IDataModel
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
