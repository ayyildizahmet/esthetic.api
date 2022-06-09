using Esthetic.Core.Contracts.EntityBase;
using Esthetic.Core.Contracts.Enums;

namespace Esthetic.Domain
{
    public class Video : Entity<int>
    {
        public string Name { get; set; }
        public string Url { get; set; }
       
    }
}
