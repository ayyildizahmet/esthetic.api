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
using Esthetic.Core.Contracts.Utilities;
using System.Linq;
using AutoMapper;
using Esthetic.Model;
using Esthetic.Core.Contracts.Enums;

namespace Esthetic.Service
{
    public class ImageService : Core.Contracts.ServiceBase.Service, IImageService
    {
        private readonly IImageRepository _imageRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _config;
        public static IHostingEnvironment Environment;
        private readonly IMediaUtility _mediaUtility;
        private readonly IMapper _mapper;

        public ImageService(IImageRepository imageRepository, IUnitOfWork unitOfWork, IConfiguration config, IHostingEnvironment environment, IMediaUtility mediaUtility, IMapper mapper)
        {
            Environment = environment;
            _mediaUtility = mediaUtility;
            _mapper = mapper;
            _imageRepository = imageRepository;
            _unitOfWork = unitOfWork;
            _config = config;
        }

        public ImageModel GetImage(Guid id)
        {
            var image = _imageRepository.Where(x => x.Id == id).Select(x =>
            new Image
            {
                Id = x.Id,
                Extension = x.Extension,
                CreatedDate = x.CreatedDate,
                ModifiedDate = x.ModifiedDate,
                Size = x.Size,
                Data = x.Data,
                ImageType = x.ImageType,
                ImageCategoryType = x.ImageCategoryType,
                State = x.State,
            });

            return _mapper.Map<ImageModel>(image);
        }

        public ImageModel GetImageWithoutData(Guid id)
        {
            var image = _imageRepository.Where(x => x.Id == id).Select(x =>
            new Image
            {
                Id = x.Id,
                Extension = x.Extension,
                CreatedDate = x.CreatedDate,
                ModifiedDate = x.ModifiedDate,
                Size = x.Size,
                ImageType = x.ImageType,
                ImageCategoryType = x.ImageCategoryType,
                State = x.State,
            }).FirstOrDefault();

            if (image != null)
            {
                var imageModel = _mapper.Map<ImageModel>(image);
                imageModel.Url = GenerateUrl(image);
                return imageModel;
            }
            return null;
        }

        public string GenerateUrl(Image image)
        {
            var directory = _config.GetSection("MediaFilePath:ImageDirectory").Value;
            var hostName = _config.GetSection("MediaFilePath:HostName").Value;
            var port = _config.GetSection("MediaFilePath:Port").Value;
            if (directory == null || hostName == null || port == null || image.Extension == null) return null;
            var url = Path.Combine(hostName + ":" + port + "\\" + directory, image.Id + "." + image.Extension);
            GenerateFileIfNotExist(image);
            return url;
        }

        public void GenerateFileIfNotExist(Image image)
        {
            var filePath = _config.GetSection("MediaFilePath:Path").Value;
            var exists = File.Exists(Path.Combine(filePath, image.Id + "." + image.Extension));
            if (!exists)
            {
                var selectedImage = _imageRepository.FirstOrDefault(x => x.Id == image.Id);
                if (selectedImage != null)
                    CreateImageToFolder(selectedImage);
            }

            
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
                throw new Exception(
                    $"Error occurred while uploading file. Error = {ex.Message} Exception = {ex.InnerException}");
            }
        }

        public Image CreateImageToDatabase(IFormFile image)
        {
            try
            {
                using var dataStream = new MemoryStream();
                image.CopyTo(dataStream);
                byte[] imageBytes = dataStream.ToArray();

                Image imageObject = new Image
                {
                    Id = Guid.NewGuid(),
                    Data = imageBytes,
                    Size = image.Length / (1024.0 * 1024.0),
                    Name = image.FileName,
                    ImageType = _mediaUtility.GetImageType(image.ContentType) ?? Core.Contracts.Enums.ImageType.Unknown,
                    Extension = image.ContentType.Split('/').LastOrDefault()
                };

                _imageRepository.Add(imageObject);
                _unitOfWork.SaveChanges();
                return imageObject;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error occurred while saving file to database. Error = {ex.Message} Exception = {ex.InnerException}");
            }
        }

        public void CreateImageToFolder(Image image)
        {
            try
            {
                using System.Drawing.Image imageFile = System.Drawing.Image.FromStream(new MemoryStream(image.Data));
                var pathBuilt = _config.GetSection("MediaFilePath:Path").Value;
                //if (Environment.IsDevelopment())
                //    pathBuilt = Environment.ContentRootPath + "Uploads";

                if (pathBuilt != null)
                {
                    if (!Directory.Exists(pathBuilt))
                        Directory.CreateDirectory(pathBuilt);

                    imageFile.Save(Path.Combine(pathBuilt, image.Id + _mediaUtility.FileExtensionFromConverter(imageFile.RawFormat)));
                }
                else
                {
                    throw new Exception("MediaFilePath:Path value can not be null");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error occurred while saving file to disk. Error = {ex.Message} Exception = {ex.InnerException}");
            }
        }
    }
}