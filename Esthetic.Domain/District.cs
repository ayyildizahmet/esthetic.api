using Esthetic.Core.Contracts.EntityBase;

namespace Esthetic.Domain
{
    public class District : Entity<int>
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
