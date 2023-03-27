using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
    }
}
