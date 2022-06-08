using System.Collections.Generic;
using Esthetic.Core.Contracts.EntityBase;

namespace Esthetic.Domain
{
    public class Category : Entity<int>
    {
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        

    }
}
