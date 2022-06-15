using Esthetic.Core.Contracts.EntityBase;
using Esthetic.Core.Contracts.Enums;
using System;

namespace Esthetic.Domain
{
    public class PostMedia : Entity<int>
    {
        public int PostId { get; set; }
        public int Day { get; set; }
        public string Content { get; set; }
        public MediaType MediaType { get; set; }
        public OperationStatusType OperationStatusType { get; set; }
        public Guid? ImageId { get; set; }
        public Guid? VideoId { get; set; }
        public Image Image { get; set; }
        public Video Video { get; set; }
        public Post Post { get; set; }
    }
}
