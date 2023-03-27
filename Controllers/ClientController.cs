using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
    }
}
