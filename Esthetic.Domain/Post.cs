using Esthetic.Core.Contracts.EntityBase;
using System.Collections.Generic;

namespace Esthetic.Domain
{
    public class Post : Entity<int>
    {
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public List<PostMedia> PostMedias { get; set; }
        //public List<LikeStatistic> LikeStatistics { get; set; }
        //public List<ViewStatistic> ViewsStatistics { get; set; }
    }
}
