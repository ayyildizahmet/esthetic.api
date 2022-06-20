using System;
using Esthetic.Core.Contracts.EntityBase;


namespace Esthetic.Domain
{
    public class OperationType : Entity<int>
    {
        public string Name { get; set; }
        public Image Image { get; set; }

    }
}
