using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.Enums;

namespace Esthetic.Model
{
    public class ImageModel : IDataModel
    {
        public int Id { get; set; }
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