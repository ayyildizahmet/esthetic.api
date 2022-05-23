using System.Collections.Generic;
using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class UserType:Entity<int>
    {
        public string Name { get; set; }
    }
}
