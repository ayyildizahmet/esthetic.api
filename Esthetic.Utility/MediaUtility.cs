using Esthetic.Core.Contracts.Enums;
using Esthetic.Core.Contracts.Utilities;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace Esthetic.Utility
{
    public class MediaUtility : IMediaUtility
    {
        public ImageType? GetImageType(string contentType)
        {
            var selectedType = contentType?.Split('/').LastOrDefault();
            if (selectedType != null)
                switch (selectedType)
                {
                    case "jpeg":
                        return ImageType.Jpeg;
                    case "png":
                        return ImageType.Png;
                }
            return null;
        }

        public MediaType? GetMediaType(string contentType)
        {
            var selectedType = contentType?.Split('/').FirstOrDefault();
            if (selectedType != null)
                switch (selectedType)
                {
                    case "image":
                        return MediaType.Image;
                    case "video":
                        return MediaType.Video;
                }
            return null;
        }

        //Attempt 1: Use ImageCodecInfo.GetImageEncoders
        public string FileExtensionFromEncoder(ImageFormat format)
        {
            try
            {
                var filenameExtension = ImageCodecInfo.GetImageEncoders()
                    .First(x => x.FormatID == format.Guid)
                    .FilenameExtension;
                if (filenameExtension != null)
                    return filenameExtension
                        .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .First()
                        .Trim('*')
                        .ToLower();
            }
            catch (Exception)
            {
                return ".IDFK";
            }

            return null;
        }

        //Attempt 2: Using ImageFormatConverter().ConvertToString()
        public string FileExtensionFromConverter(ImageFormat format)
        {
            return "." + new ImageFormatConverter().ConvertToString(format)?.ToLower();
        }

        //Attempt 3: Using ImageFormat.ToString()
        public string FileExtensionFromToString(ImageFormat format)
        {
            return "." + format.ToString().ToLower();
        }
    }
}


