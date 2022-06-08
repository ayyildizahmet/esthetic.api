using System.Collections.Generic;
using Esthetic.Core.Contracts.EntityBase;

namespace Esthetic.Domain
{
    public class City : Entity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual List<District> Districts { get; set; }
    }
}
