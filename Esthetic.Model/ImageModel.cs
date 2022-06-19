using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.Enums;
using System;

namespace Esthetic.Model
{
    public class ImageModel : IDataModel
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public byte[] Data { get; set; }
        public string Extension { get; set; }
        public ImageType ImageType { get; set; }
        public ImageCategoryType ImageCategoryType { get; set; }
    }
}