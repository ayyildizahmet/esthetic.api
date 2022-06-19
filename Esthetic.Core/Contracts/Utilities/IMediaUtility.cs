using Esthetic.Core.Contracts.Enums;
using System;
using System.Drawing.Imaging;
using System.Linq;

namespace Esthetic.Core.Contracts.Utilities
{
    public interface IMediaUtility : IUtility
    {
        MediaType? GetMediaType(string contentType);
        ImageType? GetImageType(string contentType);
        string FileExtensionFromEncoder(ImageFormat format);
        string FileExtensionFromConverter(ImageFormat format);
        string FileExtensionFromToString(ImageFormat format);
    }
}
