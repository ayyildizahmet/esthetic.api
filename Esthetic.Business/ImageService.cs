using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;
using Esthetic.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;


namespace Esthetic.Service
{
    public class ImageService : Core.Contracts.ServiceBase.Service, IImageService
    {
        private const string folder_name = "\\uploads\\";
        private readonly IImageRepository _imageRepository;
        private readonly IUnitOfWork _unitOfWork;
        public static IHostEnvironment _environment;

        public ImageService(IImageRepository imageRepository, IUnitOfWork unitOfWork, IHostEnvironment environment)
        {
            _environment = environment;
            _imageRepository = imageRepository;
            _unitOfWork = unitOfWork;
        }

        public Guid Upload(IFormFile image)
        {
            //compress befores store
            var uploadedImage = CreateImageToDatabase(image);

            CreateImageToFolder(uploadedImage);

            return uploadedImage.Id;
        }

        public Image CreateImageToDatabase(IFormFile image)
        {
            if (image != null)
            {
                using var dataStream = new MemoryStream();
                image.CopyToAsync(dataStream);
                byte[] imageBytes = dataStream.ToArray();

                Image imageObject = new Image
                {
                    Id = Guid.NewGuid(),
                    Data = imageBytes,
                    Size = (int)(image.Length / (1024*1024)),
                    ImageType = Core.Contracts.Enums.ImageType.Jpeg,
                };

                _imageRepository.Add(imageObject);
                _unitOfWork.SaveChanges();
                return imageObject;
            }

            throw new Exception("Error occurred while saving file to database.");
        }

        public void CreateImageToFolder(Image image)
        {
            try
            {
                if (!Directory.Exists(_environment.ContentRootPath + folder_name))
                {
                    Directory.CreateDirectory(_environment.ContentRootPath + folder_name);
                }

                using (System.Drawing.Image imagex = System.Drawing.Image.FromStream(new MemoryStream(image.Data)))
                {
                    imagex.Save(_environment.ContentRootPath + "\\uploads\\" + image.Id.ToString() + ".jpg");
                }

            }
            catch (Exception ex)
            {
                //return default(Guid);
            }
        }
    }
}