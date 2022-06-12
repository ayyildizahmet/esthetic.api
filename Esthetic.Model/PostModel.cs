using System;
using System.Collections.Generic;
using Esthetic.Core.Contracts.Data;

namespace Esthetic.Model
{
    public class PostModel : IDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public List<PostMediaModel> PostMedias { get; set; }
    }
}
