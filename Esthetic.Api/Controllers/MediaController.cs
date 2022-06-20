using System;
using Esthetic.Model;
using Esthetic.Utility;
using Esthetic.Core.Contracts.Enums;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Esthetic.Service.Contracts;


namespace Esthetic.Api.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class MediaController : ControllerBase
    {
        private readonly IImageService _imageService;
        private readonly MediaUtility _mediaUtility;

        public MediaController(IImageService imageService)
        {
            _mediaUtility = new MediaUtility();
            _imageService = imageService;
        }

        [HttpPost("upload")]
        [RequestFormLimits(MultipartBodyLengthLimit = 134217728)]
        [DisableRequestSizeLimit]
        public Task<ResponseModel<Guid>> Upload(IFormFile file, ImageCategoryType categoryType)
        {
            var response = new ResponseModel<Guid>();
            try
            {
                if (file.Length <= 0)
                    throw new Exception("Media cannot be null.");
                else
                {
                    var mediaType = _mediaUtility.GetMediaType(file.ContentType);

                    if (mediaType is not null)
                        switch (mediaType)
                        {
                            case MediaType.Image:
                                response.Data = _imageService.Upload(file);
                                break;
                            case MediaType.Video:
                                Console.WriteLine("video service");
                                break;
                        }
                    else
                        throw new Exception("Unsupported media type.");
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            if (response.Success)
                response.Message = "Media uploaded successfully.";

            return Task.FromResult(response);
        }
    }
}
