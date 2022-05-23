using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class Branch : Entity<int>
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Company Company { get; set; }
    }
}
