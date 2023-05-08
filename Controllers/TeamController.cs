using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/team")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamInfo _teamInfo;
        public TeamController(ITeamInfo teamInfo)
        {
            _teamInfo = teamInfo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCRMTEAM>>> Get()
        {
            return await Task.FromResult(_teamInfo.GetTeamInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLCRMTEAM>> Get(int id)
        {
            ActionResult<TBLCRMTEAM> TeamInfo = await Task.FromResult(_teamInfo.GetTeamDetails(id));
            if (TeamInfo == null)
            {
                return NotFound();
            }
            return TeamInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLCRMTEAM>> Post(TBLCRMTEAM teamInfo)
        {
            _teamInfo.AddTeamInfo(teamInfo);
            return await Task.FromResult(teamInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLCRMTEAM>> Put(int id, TBLCRMTEAM teamInfo)
        {
            if (id.ToString() != teamInfo.EMPID)
            {
                return BadRequest();
            }
            try
            {
                _teamInfo.UpdateTeamInfo(teamInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(teamInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLCRMTEAM>> Delete(int id)
        {
            var teamInfo = _teamInfo.DeleteTeamInfo(id);
            return await Task.FromResult(teamInfo);
        }

        [HttpGet]
        private bool TeamInfoExists(int id)
        {
            return _teamInfo.CheckTeamInfo(id);
        }
    }
}
