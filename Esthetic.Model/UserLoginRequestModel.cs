using MakeEat.Core.Contracts.Data;

namespace MakeEat.Model
{
    public class UserLoginRequestModel : IDataModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}