using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/group")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly ITBLCRMGROUP _tblcrmgroup;

        public GroupController(ITBLCRMGROUP tblcrmgroup)
        {
            _tblcrmgroup = tblcrmgroup;
        }



    }
}
