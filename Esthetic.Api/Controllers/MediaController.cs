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
        public Task<ResponseModel<Guid>> Upload(IFormFile file)
        {
            var response = new ResponseModel<Guid>();
            try
            {
                if (file.Length > 0 && file.ContentType is not null)
                {
                    var mediaType = _mediaUtility.GetMediaType(file.ContentType);

                    if (mediaType is not null)
                    {
                        switch (mediaType)
                        {
                            case MediaType.Image:
                                response.Data = _imageService.Upload(file);
                                break;
                            case MediaType.Video:
                                Console.WriteLine("video service");
                                break;
                        }
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = "Unsupported media type.";
                    }
                }
                else
                {
                    response.Success = false;
                    response.Message = "Media cannot be null.";
                }

                if (response.Success)
                    response.Message = "Media uploaded successfully.";
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
           
            return Task.FromResult(response);
        }
    }
}
