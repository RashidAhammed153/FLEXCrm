using FLEXCrm.Data;
using FLEXCrm.Models;
using FLEXCrm.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/clientAMC")]
    [ApiController]
    public class ClientAMCController : ControllerBase
    {
        private readonly FLEXBDContext _context;
        public IConfiguration Configuration { get; }

        public ClientAMCController(FLEXBDContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {



            var AMCList = (from amc in _context.TBLCRMTECHAMC
                           join master in _context.TBLCRMTECHMASTER
                           on amc.TMID equals master.TMID
                           join client in _context.TBLCRMCLIENT
                           on master.CRCID equals client.CRCID
                           select new ClientAMCVM
                           {
                               CRCNAME = client.CRCNAME,
                               SVERSION = master.SVERSION,
                               SMODULE = master.SMODULE,
                               AUPDATE = (DateTime)amc.AUPDATE,
                               OLICENCE = amc.OLICENCE,
                               OLSTATUS = amc.OLSTATUS,
                               STATUS = amc.STATUS,
                               PTYPE = amc.PTYPE,
                               SWVERSION = amc.SWVERSION,
                               TAID = amc.TAID,
                           }).OrderBy(x => x.TAID).ToList();

            return Ok(AMCList);
        }



        [HttpPost]
        public IActionResult CreateAMC(TBLCRMTECHAMC model)
        {
            var MasterID = _context.TBLCRMTECHAMC.Where(x => x.TMID == model.TMID).FirstOrDefault();
            var TAID = "0";
            if (MasterID == null)
            {
                var LastIndex = (model.TMID.LastOrDefault());
                TAID = (model.TMID + "0" + LastIndex);
            }
            else
            {
                var LastIndex = (MasterID.TMID.LastOrDefault());
                LastIndex = ((char)(Convert.ToInt64(LastIndex) + 1));
                TAID = MasterID.TMID + "0" + LastIndex;
            }
            var newAMC = new TBLCRMTECHAMC()
            {
                TAID = TAID.ToString(),
                TMID = model.TMID,
                PTYPE = model.PTYPE,
                OLICENCE = model.OLICENCE,
                QUANTITY = model.QUANTITY,
                SPRICE = model.SPRICE,
                TOTAL = model.TOTAL,
                DISCOUNT = model.DISCOUNT,
                STATUS = model.STATUS,
                CDATE = DateTime.UtcNow.AddHours(6),
                UPSTATUS = "",
                DNSTATUS = "NEW",
                USRID = HttpContext.Session.GetString("UserID"),
                BID = "201",

            };
            _context.TBLCRMTECHAMC.Add(newAMC);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet("Details")]
        public IActionResult Details(string id)
        {
            if (id != null)
            {
                var SelectedRow = _context.TBLCRMTECHAMC.Where(x => x.TAID == id).FirstOrDefault();
                return Ok(SelectedRow);
            }
            return BadRequest("Not Found");
        }

        [HttpDelete]
        public IActionResult Delete(TBLCRMTECHAMC model)
        {
            if (model.TAID != null)
            {
                var DeleteRow = _context.TBLCRMTECHAMC.Where(x => x.TAID == model.TAID).FirstOrDefault();
                if (DeleteRow != null)
                {
                    _context.Remove(DeleteRow);
                    _context.SaveChanges();
                    return Ok("Successfully Deleted");
                }
            }
            return BadRequest();
        }

    }
}
