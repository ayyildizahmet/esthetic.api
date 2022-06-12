using Esthetic.Core.Contracts.EntityBase;
using System;

namespace Esthetic.Domain
{
    public class Video : Entity<Guid>
    {
        public string Name { get; set; }
        public string Url { get; set; }
       
    }
}
