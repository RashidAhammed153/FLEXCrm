using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/team")]
    [ApiController]
    public class TeamController : ControllerBase
    {
    }
}
