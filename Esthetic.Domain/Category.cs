using System.Collections.Generic;
using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class Category : Entity<int>
    {
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public List<Product> Products { get; set; }

    }
}
