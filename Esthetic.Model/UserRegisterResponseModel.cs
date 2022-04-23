using MakeEat.Core.Contracts.Data;

namespace MakeEat.Model
{
    public class UserRegisterResponseModel : IDataModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}