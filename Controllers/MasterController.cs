using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/master")]
    [ApiController]
    public class MasterController : ControllerBase
    {
    }
}
