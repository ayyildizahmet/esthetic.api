using Esthetic.Core.Contracts.Data;
using System;

namespace Esthetic.Model
{
    public class VideoModel : IDataModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}