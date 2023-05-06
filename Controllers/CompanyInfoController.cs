using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/companyInfo")]
    [ApiController]
    public class CompanyInfoController : ControllerBase
    {
        private readonly ICompanyInfo _companyInfo;

        public CompanyInfoController(ICompanyInfo IcompanyInfo)
        {
            _companyInfo = IcompanyInfo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCOMINFO>>> Get()
        {
            return await Task.FromResult(_companyInfo.GetCompanyInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLCOMINFO>> Get(int id)
        {
            ActionResult<TBLCOMINFO> CompanyInfo = await Task.FromResult(_companyInfo.GetCompanyDetails(id));
            if (CompanyInfo == null)
            {
                return NotFound();
            }
            return CompanyInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLCOMINFO>> Post(TBLCOMINFO companyInfo)
        {
            _companyInfo.AddCompanyInfo(companyInfo);
            return await Task.FromResult(companyInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLCOMINFO>> Put(int id, TBLCOMINFO companyInfo)
        {
            if (id != companyInfo.COMID)
            {
                return BadRequest();
            }
            try
            {
                _companyInfo.UpdateCompanyInfo(companyInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(companyInfo);
        }


        // DELETE api/CompanyInfo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLCOMINFO>> Delete(int id)
        {
            var companyInfo = _companyInfo.DeleteCompanyInfo(id);
            return await Task.FromResult(companyInfo);
        }


        [HttpGet]
        private bool CompanyInfoExists(int id)
        {
            return _companyInfo.CheckCompanyInfo(id);
        }

    }
}
