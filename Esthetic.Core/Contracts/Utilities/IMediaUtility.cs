using Esthetic.Core.Contracts.Enums;

namespace Esthetic.Core.Contracts.Utilities
{
    public interface IMediaUtility : IUtility
    {
        MediaType? GetMediaType(string contentType);

        ImageType? GetImageType(string contentType);
        
    }
}
