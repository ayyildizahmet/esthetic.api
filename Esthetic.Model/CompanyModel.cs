using Esthetic.Core.Contracts.Data;

namespace Esthetic.Model
{
    public class CompanyModel : IDataModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }

    }
}