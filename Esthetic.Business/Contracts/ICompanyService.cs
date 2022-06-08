using System.Collections.Generic;
using Esthetic.Core.Contracts.ServiceBase;
using Esthetic.Model;

namespace Esthetic.Service.Contracts
{
    public interface ICompanyService : IService
    {
       List<CompanyModel> GetList();
    }
}