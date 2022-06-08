using System.Collections.Generic;
using Esthetic.Core.Contracts.EntityBase;

namespace Esthetic.Domain
{
    public class UserType:Entity<int>
    {
        public string Name { get; set; }
    }
}
