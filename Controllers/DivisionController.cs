using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Controllers
{
    //[Route("api/[division]")]
    //[ApiController]
    //public class DivisionController : ControllerBase
    //{
    //}

    [Authorize]
    [Route("api/division")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        private readonly ITBLDIVISION _TBLDIVISION;

        public DivisionController(ITBLDIVISION TBLDIVISION)
        {
            _TBLDIVISION = TBLDIVISION;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLDIVISION>>> Get()
        {
            return await Task.FromResult(_TBLDIVISION.GetDivisionInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLDIVISION>> Get(int id)
        {
            ActionResult<TBLDIVISION> DivisionInfo = await Task.FromResult(_TBLDIVISION.GetDivisionDetails(id));
            if (DivisionInfo == null)
            {
                return NotFound();
            }
            return DivisionInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLDIVISION>> Post(TBLDIVISION DivisionInfo)
        {
            _TBLDIVISION.AddDivisionInfo(DivisionInfo);
            return await Task.FromResult(DivisionInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLDIVISION>> Put(int id, TBLDIVISION DivisionInfo)
        {
            if (id.ToString() != DivisionInfo.DIVID)
            {
                return BadRequest();
            }
            try
            {
                _TBLDIVISION.UpdateDivisionInfo(DivisionInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DivisionInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(DivisionInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLDIVISION>> Delete(int id)
        {
            var DivisionInfo = _TBLDIVISION.DeleteDivisionInfo(id);
            return await Task.FromResult(DivisionInfo);
        }

        [HttpGet]
        private bool DivisionInfoExists(int id)
        {
            return _TBLDIVISION.CheckDivisionInfo(id);
        }


    }
}
