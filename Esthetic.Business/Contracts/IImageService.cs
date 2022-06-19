using Esthetic.Core.Contracts.ServiceBase;
using Microsoft.AspNetCore.Http;
using Esthetic.Domain;
using System;
using Esthetic.Model;

namespace Esthetic.Service.Contracts
{
    public interface IImageService : IService
    {
        string GenerateUrl(Image image);
        ImageModel GetImage(Guid id);
        ImageModel GetImageWithoutData(Guid id);
        Guid Upload(IFormFile image);
        Image CreateImageToDatabase(IFormFile image);
        void CreateImageToFolder(Image image);
    }
}