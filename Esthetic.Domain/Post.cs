using Esthetic.Core.Contracts.Enums;
using System.Collections.Generic;

namespace Esthetic.Domain
{
    public class Post
    {
        public string Name { get; set; }
        public MediaType MediaType { get; set; }
        public Company Company { get; set; }
        public List<Image> Images { get; set; }
        public List<LikeStatistic> LikeStatistics { get; set; }
        public List<ViewStatistic> ViewsStatistics { get; set; }
    }
}
