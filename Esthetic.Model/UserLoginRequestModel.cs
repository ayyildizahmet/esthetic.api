using Esthetic.Core.Contracts.Data;

namespace Esthetic.Model
{
    public class UserLoginRequestModel : IDataModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}