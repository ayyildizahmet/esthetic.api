using Esthetic.Core.Contracts.Data;

namespace Esthetic.Model
{
    public class UserRegisterRequestModel : IDataModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string CountryCode { get; set; }
        public string Password { get; set; }
        
    }
}