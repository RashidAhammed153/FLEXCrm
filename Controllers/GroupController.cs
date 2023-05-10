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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCRMGROUP>>> Get()
        {
            return await Task.FromResult(_tblcrmgroup.GetGroupInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLCRMGROUP>> Get(int id)
        {
            ActionResult<TBLCRMGROUP> GroupInfo = await Task.FromResult(_tblcrmgroup.GetGroupDetails(id));
            if (GroupInfo == null)
            {
                return NotFound();
            }
            return GroupInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLCRMGROUP>> Post(TBLCRMGROUP GroupInfo)
        {
            _tblcrmgroup.AddGroupInfo(GroupInfo);
            return await Task.FromResult(GroupInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLCRMGROUP>> Put(int id, TBLCRMGROUP GroupInfo)
        {
            if (id.ToString() != GroupInfo.CRGID)
            {
                return BadRequest();
            }
            try
            {
                _tblcrmgroup.UpdateGroupInfo(GroupInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(GroupInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLCRMGROUP>> Delete(int id)
        {
            var GroupInfo = _tblcrmgroup.DeleteGroupInfo(id);
            return await Task.FromResult(GroupInfo);
        }

        [HttpGet]
        private bool GroupInfoExists(int id)
        {
            return _tblcrmgroup.CheckGroupInfo(id);
        }


    }
}
