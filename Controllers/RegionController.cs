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
    [Route("api/region")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly ITBLCRMREGION _TBLCRMREGION;

        public RegionController(ITBLCRMREGION TBLCRMREGION)
        {
            _TBLCRMREGION = TBLCRMREGION;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCRMREGION>>> Get()
        {
            return await Task.FromResult(_TBLCRMREGION.GetRegionInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLCRMREGION>> Get(int id)
        {
            ActionResult<TBLCRMREGION> RegionInfo = await Task.FromResult(_TBLCRMREGION.GetRegionDetails(id));
            if (RegionInfo == null)
            {
                return NotFound();
            }
            return RegionInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLCRMREGION>> Post(TBLCRMREGION RegionInfo)
        {
            _TBLCRMREGION.AddRegionInfo(RegionInfo);
            return await Task.FromResult(RegionInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLCRMREGION>> Put(int id, TBLCRMREGION RegionInfo)
        {
            if (id.ToString() != RegionInfo.DIID)
            {
                return BadRequest();
            }
            try
            {
                _TBLCRMREGION.UpdateRegionInfo(RegionInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegionInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(RegionInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLCRMREGION>> Delete(int id)
        {
            var RegionInfo = _TBLCRMREGION.DeleteRegionInfo(id);
            return await Task.FromResult(RegionInfo);
        }

        [HttpGet]
        private bool RegionInfoExists(int id)
        {
            return _TBLCRMREGION.CheckRegionInfo(id);
        }


    }
}
