using Esthetic.Core.Contracts.EntityBase;
using Esthetic.Core.Contracts.Enums;

namespace Esthetic.Domain
{
    public class Image : Entity<System.Guid>
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public double Size { get; set; }
        public string Extension { get; set; }
        public ImageType ImageType { get; set; }
        public ImageCategoryType ImageCategoryType { get; set; }
    }
}
