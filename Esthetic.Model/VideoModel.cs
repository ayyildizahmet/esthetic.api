using Esthetic.Core.Contracts.Data;

namespace Esthetic.Model
{
    public class VideoModel : IDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}