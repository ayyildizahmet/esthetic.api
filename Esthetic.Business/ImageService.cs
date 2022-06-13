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
            try
            {
                if (image == null)
                    throw new NullReferenceException();

                var uploadedImage = CreateImageToDatabase(image);

                CreateImageToFolder(uploadedImage);

                return uploadedImage.Id;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while uploading file. Error = " + ex.Message);
            }
        }

        public Image CreateImageToDatabase(IFormFile image)
        {
            try
            {
                using var dataStream = new MemoryStream();
                image.CopyToAsync(dataStream);
                byte[] imageBytes = dataStream.ToArray();

                Image imageObject = new Image
                {
                    Id = Guid.NewGuid(),
                    Data = imageBytes,
                    Size = image.Length / (1024 * 1024),
                    ImageType = Core.Contracts.Enums.ImageType.Jpeg,
                };

                _imageRepository.Add(imageObject);
                _unitOfWork.SaveChanges();
                return imageObject;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while saving file to database. Error = " + ex.Message);
            }
        }

        public void CreateImageToFolder(Image image)
        {
            try
            {
                if (!Directory.Exists(_environment.ContentRootPath + folder_name))
                {
                    Directory.CreateDirectory(_environment.ContentRootPath + folder_name);
                }

                using (System.Drawing.Image imageFile = System.Drawing.Image.FromStream(new MemoryStream(image.Data)))
                {
                    imageFile.Save(_environment.ContentRootPath + "\\uploads\\" + image.Id.ToString() + ".jpg");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while saving file to disk. Error = " + ex.Message);
            }
        }
    }
}