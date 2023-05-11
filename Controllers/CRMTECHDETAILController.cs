using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/CRMTECHDETAIL")]
    [ApiController]
    public class CRMTECHDETAILController : ControllerBase
    {
        private readonly ICRMTECHDETAIL _CRMTECHDETAIL;

        public CRMTECHDETAILController(ICRMTECHDETAIL CRMTECHDETAIL)
        {
            _CRMTECHDETAIL = CRMTECHDETAIL;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCRMTECHDETAIL>>> Get()
        {
            return await Task.FromResult(_CRMTECHDETAIL.GetCRMTECHDETAILInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLCRMTECHDETAIL>> Get(int id)
        {
            ActionResult<TBLCRMTECHDETAIL> CRMTECHAMCInfo = await Task.FromResult(_CRMTECHDETAIL.GetCRMTECHDETAILDetails(id));
            if (CRMTECHAMCInfo == null)
            {
                return NotFound();
            }
            return CRMTECHAMCInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLCRMTECHDETAIL>> Post(TBLCRMTECHDETAIL CRMTECHDETAILInfo)
        {
            _CRMTECHDETAIL.AddCRMTECHDETAILInfo(CRMTECHDETAILInfo);
            return await Task.FromResult(CRMTECHDETAILInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLCRMTECHDETAIL>> Put(int id, TBLCRMTECHDETAIL CRMTECHDETAILInfo)
        {
            if (id.ToString() != CRMTECHDETAILInfo.TMID)
            {
                return BadRequest();
            }
            try
            {
                _CRMTECHDETAIL.UpdateCRMTECHDETAILInfo(CRMTECHDETAILInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CRMTECHDETAILInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(CRMTECHDETAILInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLCRMTECHDETAIL>> Delete(int id)
        {
            var CRMTECHDETAILInfo = _CRMTECHDETAIL.DeleteCRMTECHDETAILInfo(id);
            return await Task.FromResult(CRMTECHDETAILInfo);
        }

        [HttpGet]
        private bool CRMTECHDETAILInfoExists(int id)
        {
            return _CRMTECHDETAIL.CheckCRMTECHDETAILInfo(id);
        }
    }

}
