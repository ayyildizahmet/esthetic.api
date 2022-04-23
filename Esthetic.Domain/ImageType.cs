using MakeEat.Core.Contracts.EntityBase;

namespace MakeEat.Domain
{
    public class ImageType : Entity<int>
    {
        public string Name { get; set; }
    }
}
