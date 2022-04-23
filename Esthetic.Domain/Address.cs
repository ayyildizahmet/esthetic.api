using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class Address : Entity<int>
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public User User { get; set; }
        public City City { get; set; }
        public District District { get; set; }
    }
}
