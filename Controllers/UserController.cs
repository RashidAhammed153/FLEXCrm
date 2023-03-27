using FLEXCrm.Data;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace FLEXCrm
{
    [Authorize]
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly FLEXBDContext _context;
        public IConfiguration Configuration { get; }

        private readonly IUser _user;

        public UserController(IUser Iuser)
        {
            _user = Iuser;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCOMINFO>>> Get()
        {
            return await Task.FromResult(_user.GetUserList());
        }
    }
}