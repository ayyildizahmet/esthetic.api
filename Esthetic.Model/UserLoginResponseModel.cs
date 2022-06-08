using Esthetic.Core.Contracts.Data;

namespace Esthetic.Model
{
    public class UserLoginResponseModel : IDataModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AccessTokenModel Security { get; set; }
    }
}