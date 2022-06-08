using System.Collections.Generic;
using Esthetic.Core.Contracts.EntityBase;

namespace Esthetic.Domain
{
    public class User:Entity<int>
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string CountryCode { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
