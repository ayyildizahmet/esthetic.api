using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Esthetic.Api.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class OperationController : ControllerBase
    {
       
       
    }
}
