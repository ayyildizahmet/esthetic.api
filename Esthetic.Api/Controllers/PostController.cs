using Esthetic.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Esthetic.Api.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PostController : ControllerBase
    {
        [HttpPost]
        public void Create([FromForm]PostModel post)
        {

        }

        [HttpGet]
        public void GetList(int userId)
        {

        }
    }
}
