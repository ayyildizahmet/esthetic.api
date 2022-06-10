﻿using Esthetic.Core.Contracts.EntityBase;
using Esthetic.Core.Contracts.Enums;

namespace Esthetic.Domain
{
    public class PostMedia : Entity<int>
    {
        public int Day { get; set; }
        public int Content { get; set; }
        public int? ImageId { get; set; }
        public int? VideoId { get; set; }
        public int PostId { get; set; }
        public MediaType MediaType { get; set; }
        public Image Image { get; set; }
        public Video Video { get; set; }
        public Post Post { get; set; }
    }
}
