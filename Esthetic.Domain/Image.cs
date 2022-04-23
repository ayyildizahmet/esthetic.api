using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class Image : Entity<int>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public byte[] Data { get; set; }
        public int ImageTypeId { get; set; }
        public ImageType ImageType { get; set; }
    }
}
