using System.Collections.Generic;
using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class City : Entity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual List<District> Districts { get; set; }
    }
}
