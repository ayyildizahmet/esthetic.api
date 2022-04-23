using System;
using MakeEat.Core.Contracts.Data;

namespace MakeEat.Model
{
    public class AccessTokenModel : IDataModel
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
