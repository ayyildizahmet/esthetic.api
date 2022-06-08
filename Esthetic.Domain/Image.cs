using Esthetic.Core.Contracts.EntityBase;
using Esthetic.Core.Contracts.Enums;

namespace Esthetic.Domain
{
    public class Image : Entity<int>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public byte[] Data { get; set; }
        public int ImageTypeId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ImageType ImageType { get; set; }
        public ImageCategoryType ImageCategoryType { get; set; }
    }
}
