using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;
using Esthetic.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Esthetic.Service
{
    public class ImageService : Core.Contracts.ServiceBase.Service, IImageService
    {
        private const string folder_name = "Uploads";
        private readonly IImageRepository _imageRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _config;
        public static IHostingEnvironment _environment;
        

        public ImageService(IImageRepository imageRepository, IUnitOfWork unitOfWork, IConfiguration config, IHostingEnvironment environment)
        {
            _environment = environment;
            _imageRepository = imageRepository;
            _unitOfWork = unitOfWork;
            _config = config;
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
                var pathBuilt = _config.GetSection("MediaFilePath:Path").Value;
                //if (_environment.IsDevelopment())
                //{
                //    pathBuilt = Path.Combine(_environment.ContentRootPath, folder_name);
                //}         
                
                if (!Directory.Exists(pathBuilt))
                {
                    Directory.CreateDirectory(pathBuilt);
                }

                using (System.Drawing.Image imageFile = System.Drawing.Image.FromStream(new MemoryStream(image.Data)))
                {
                    imageFile.Save(Path.Combine(pathBuilt, image.Id.ToString() + ".jpg"));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while saving file to disk. Error = " + ex.Message);
            }
        }
    }
}