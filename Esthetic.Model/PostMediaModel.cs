using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.Enums;

namespace Esthetic.Model
{
    public class PostMediaModel : IDataModel
    {
        public int Day { get; set; }
        public string Content { get; set; }
        public int? ImageId { get; set; }
        public int? VideoId { get; set; }
        public int PostId { get; set; }
        public OperationStatusType OperationStatusType { get; set; }
        public MediaType MediaType { get; set; }
        public ImageModel Image { get; set; }
        public VideoModel Video { get; set; }
    }
}