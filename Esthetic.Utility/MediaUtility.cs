using Esthetic.Core.Contracts.Enums;
using Esthetic.Core.Contracts.Utilities;
using System.Linq;

namespace Esthetic.Utility
{
    public class MediaUtility : IMediaUtility
    {
        public ImageType? GetImageType(string contentType)
        {
            if (contentType is not null)
            {
                var selectedType = contentType.Split('/').LastOrDefault();

                if (selectedType != null)
                    switch (selectedType)
                    {
                        case "jpeg":
                            return ImageType.Jpeg;
                        case "png":
                            return ImageType.Png;
                    }
            }
            return null;
        }

        public MediaType? GetMediaType(string contentType)
        {
            if (contentType is not null)
            {
                var selectedType = contentType.Split('/').FirstOrDefault();
                if (selectedType != null)
                    switch (selectedType)
                    {
                        case "image":
                            return MediaType.Image;
                        case "video":
                            return MediaType.Video;
                    }
            }
            return null;
        }


    }
}
