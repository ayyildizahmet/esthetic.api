using Esthetic.Model;
using Esthetic.Service.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Esthetic.Api.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class MediaController : ControllerBase
    {
        [Obsolete]
        public static IHostingEnvironment _environment;

        [Obsolete]
        public MediaController(IHostingEnvironment environment)
        {
            _environment = environment;
        }
        public class FIleUploadAPI
        {
            public IFormFile files { get; set; }
        }
        [HttpPost("upload")]
        [Obsolete]
        public Task<string> Upload([FromBody]IFormFile file)
        {
            if (file.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.ContentRootPath + "\\uploads\\"))
                    {
                        Directory.CreateDirectory(_environment.ContentRootPath + "\\uploads\\");
                    }
                    using (FileStream filestream = System.IO.File.Create(_environment.ContentRootPath + "\\uploads\\" + file.FileName))
                    {
                        file.CopyTo(filestream);
                        filestream.Flush();
                        return Task.FromResult("\\uploads\\" + file.FileName);
                    }
                }
                catch (Exception ex)
                {
                    return Task.FromResult(ex.ToString());
                }
            }
            else
            {
                return Task.FromResult("Unsuccessful");
            }

        }
    }
}
