using Esthetic.Core.Contracts.ServiceBase;
using Microsoft.AspNetCore.Http;
using Esthetic.Domain;
using System;

namespace Esthetic.Service.Contracts
{
    public interface IImageService : IService
    {
        public Guid Upload(IFormFile image);
        public Image CreateImageToDatabase(IFormFile image);
        public void CreateImageToFolder(IFormFile image);
    }
}