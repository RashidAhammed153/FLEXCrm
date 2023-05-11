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
    [Route("api/CRMTECHMASTER")]
    [ApiController]
    public class CRMTECHMASTERController : ControllerBase
    {
        private readonly ICRMTECHMASTER _TBLCRMTECHMASTER;

        public CRMTECHMASTERController(ICRMTECHMASTER TBLCRMTECHMASTER)
        {
            _TBLCRMTECHMASTER = TBLCRMTECHMASTER;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCRMTECHMASTER>>> Get()
        {
            return await Task.FromResult(_TBLCRMTECHMASTER.GetTBLCRMTECHMASTERInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLCRMTECHMASTER>> Get(int id)
        {
            ActionResult<TBLCRMTECHMASTER> TBLCRMTECHMASTERInfo = await Task.FromResult(_TBLCRMTECHMASTER.GetTBLCRMTECHMASTERDetails(id));
            if (TBLCRMTECHMASTERInfo == null)
            {
                return NotFound();
            }
            return TBLCRMTECHMASTERInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLCRMTECHMASTER>> Post(TBLCRMTECHMASTER TBLCRMTECHMASTERInfo)
        {
            _TBLCRMTECHMASTER.AddTBLCRMTECHMASTERInfo(TBLCRMTECHMASTERInfo);
            return await Task.FromResult(TBLCRMTECHMASTERInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLCRMTECHMASTER>> Put(int id, TBLCRMTECHMASTER TBLCRMTECHMASTERInfo)
        {
            if (id.ToString() != TBLCRMTECHMASTERInfo.TMID)
            {
                return BadRequest();
            }
            try
            {
                _TBLCRMTECHMASTER.UpdateTBLCRMTECHMASTERInfo(TBLCRMTECHMASTERInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TBLCRMTECHMASTERInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(TBLCRMTECHMASTERInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLCRMTECHMASTER>> Delete(int id)
        {
            var TBLCRMTECHMASTERInfo = _TBLCRMTECHMASTER.DeleteTBLCRMTECHMASTERInfo(id);
            return await Task.FromResult(TBLCRMTECHMASTERInfo);
        }

        [HttpGet]
        private bool TBLCRMTECHMASTERInfoExists(int id)
        {
            return _TBLCRMTECHMASTER.CheckTBLCRMTECHMASTERInfo(id);
        }
    }
}
