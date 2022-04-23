using System.Collections.Generic;
using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Image> Images { get; set; }
    }
}
