using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/country")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryInfo _countryInfo;

        public CountryController(ICountryInfo countryInfo)
        {
            _countryInfo = countryInfo;
        }

        [HttpGet]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBLCOUNTRY>>> Get()
        {
            return await Task.FromResult(_countryInfo.GetCountryInfoList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TBLCOUNTRY>> Get(int id)
        {
            ActionResult<TBLCOUNTRY> CountryInfo = await Task.FromResult(_countryInfo.GetCountryDetails(id));
            if (CountryInfo == null)
            {
                return NotFound();
            }
            return CountryInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TBLCOUNTRY>> Post(TBLCOUNTRY CountryInfo)
        {
            _countryInfo.AddCountryInfo(CountryInfo);
            return await Task.FromResult(CountryInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TBLCOUNTRY>> Put(int id, TBLCOUNTRY CountryInfo)
        {
            if (id.ToString() != CountryInfo.CNID)
            {
                return BadRequest();
            }
            try
            {
                _countryInfo.UpdateCountryInfo(CountryInfo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(CountryInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TBLCOUNTRY>> Delete(int id)
        {
            var CountryInfo = _countryInfo.DeleteCountryInfo(id);
            return await Task.FromResult(CountryInfo);
        }

        [HttpGet]
        private bool CountryInfoExists(int id)
        {
            return _countryInfo.CheckCountryInfo(id);
        }

    }
}
