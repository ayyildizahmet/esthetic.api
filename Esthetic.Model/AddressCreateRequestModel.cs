using MakeEat.Core.Contracts.Data;

namespace MakeEat.Model
{
    public class AddressCreateRequestModel : IDataModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public bool IsDefault { get; set; }
    }
}