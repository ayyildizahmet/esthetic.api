using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class District : Entity<int>
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
