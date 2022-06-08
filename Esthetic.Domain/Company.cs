using System.Collections.Generic;
using Esthetic.Core.Contracts.EntityBase;

namespace Esthetic.Domain
{
    public class Company:Entity<int>
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public virtual List<Branch> Branches{ get; set; } 
    }
}
