using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/CRMTECHAMC")]
    [ApiController]
    public class CRMTECHAMCController : ControllerBase
    {
        private readonly ICRMTECHAMC _CRMTECHAMC;

        public CRMTECHAMCController(ICRMTECHAMC CRMTECHAMC)
        {
            _CRMTECHAMC = CRMTECHAMC;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCRMTECHAMC>>> Get()
        {
            return await Task.FromResult(_CRMTECHAMC.GetCRMTECHAMCInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLCRMTECHAMC>> Get(int id)
        {
            ActionResult<TBLCRMTECHAMC> CRMTECHAMCInfo = await Task.FromResult(_CRMTECHAMC.GetCRMTECHAMCDetails(id));
            if (CRMTECHAMCInfo == null)
            {
                return NotFound();
            }
            return CRMTECHAMCInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLCRMTECHAMC>> Post(TBLCRMTECHAMC CRMTECHAMCInfo)
        {
            _CRMTECHAMC.AddCRMTECHAMCInfo(CRMTECHAMCInfo);
            return await Task.FromResult(CRMTECHAMCInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLCRMTECHAMC>> Put(int id, TBLCRMTECHAMC CRMTECHAMCInfo)
        {
            if (id.ToString() != CRMTECHAMCInfo.TMID)
            {
                return BadRequest();
            }
            try
            {
                _CRMTECHAMC.UpdateCRMTECHAMCInfo(CRMTECHAMCInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TBLCRMTECHAMCInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(CRMTECHAMCInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLCRMTECHAMC>> Delete(int id)
        {
            var TBLCRMTECHAMCInfo = _CRMTECHAMC.DeleteCRMTECHAMCInfo(id);
            return await Task.FromResult(TBLCRMTECHAMCInfo);
        }

        [HttpGet]
        private bool TBLCRMTECHAMCInfoExists(int id)
        {
            return _CRMTECHAMC.CheckCRMTECHAMCInfo(id);
        }
    }
}
