using System.Collections.Generic;
using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class Company:Entity<int>
    {
        public string Name { get; set; }
        public Image Logo { get; set; }
        public virtual List<Branch> Branches{ get; set; } 
    }
}
