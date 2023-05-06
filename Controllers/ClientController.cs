using FLEXCrm.Data;
using FLEXCrm.DEMODATA;
using FLEXCrm.Models;
using FLEXCrm.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly FLEXBDContext _context;
        public IConfiguration Configuration { get; }

        public ClientController(FLEXBDContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {

            List<ClientAndGroupVM> ClientDataVM;

            ClientDataVM = (from client in _context.TBLCRMCLIENT.ToList()
                            join groups in _context.TBLCRMGROUP
                             on client.CRGID equals groups.CRGID
                            join city in _context.TBLCITY
                            on client.CITY equals city.CTID
                            join division in _context.TBLDIVISION
                            on client.REGION equals division.DIVID
                            join country in _context.TBLCOUNTRY
                            on client.COUNTRY equals country.CNID
                            select new ClientAndGroupVM
                            {
                                CRGNAME = groups.CRGNAME,
                                CRGID = groups.CRGID,
                                CRCID = client.CRCID,
                                CRCNAME = client.CRCNAME,
                                CRPREFIX = client.CRPREFIX,
                                STREET = client.STREET,
                                REGION = division.DIVNAME,
                                CITY = city.CTNAME,
                                COUNTRY = country.CNNAME,
                                GRADE = client.GRADE,
                                NOTES = client.NOTES,
                                ABOUT = client.ABOUT,
                                STATUS = client.STATUS,
                                CNAME = client.CNAME,
                                DESIGNATION = client.DESIGNATION,
                                PHONE = client.PHONE,
                                FAX = client.FAX,
                                MOBILE = client.MOBILE,
                                EMAIL = client.EMAIL,
                                EMAILII = client.EMAILII,
                                WEB = client.WEB,
                                PADDRESS = client.PADDRESS

                            }).ToList();



            return Ok(ClientDataVM);
        }


        [HttpPost]
        public IActionResult Create(TBLCRMCLIENT model, IFormFile Logo)
        {
            try
            {
                var Image = new byte[0];
                if (Logo != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        Logo.CopyTo(ms);

                        var fileBytes = ms.ToArray();
                        Image = fileBytes;


                    }
                }
                var ClientIndex = "0";
                if (ModelState.IsValid)
                {
                    var ClientList = _context.TBLCRMCLIENT.ToList();

                    if (ClientList.Count == 0)
                    {
                        ClientIndex = "HI0001";
                    }
                    else
                    {
                        ClientIndex = _context.TBLCRMCLIENT.OrderByDescending(x => x.CRCID).FirstOrDefault().CRCID;
                    }
                    var CrcId = Convert.ToInt16(ClientIndex.Substring(3)) + 1;

                    var NewClient = new TBLCRMCLIENT()
                    {
                        CRCID = ("HI0" + CrcId.ToString()).ToString(),
                        CRCNAME = model.CRCNAME,
                        CNAME = model.CNAME,
                        CRPREFIX = model.CRPREFIX,
                        DESIGNATION = model.DESIGNATION,
                        STATUS = model.STATUS,
                        PADDRESS = model.PADDRESS,
                        PHONE = model.PHONE,
                        FAX = model.FAX,
                        MOBILE = model.MOBILE,
                        EMAIL = model.EMAIL,
                        EMAILII = model.EMAILII,

                        ABOUT = model.ABOUT,
                        NOTES = model.NOTES,
                        STREET = model.STREET,
                        REGION = model.REGION,
                        CLOGO = Image,
                        USRID = model.USRID,
                        CITY = model.CITY,
                        CRGID = model.CRGID,
                        COUNTRY = model.COUNTRY,
                        STATE = "",
                        WEB = model.WEB,
                        GRADE = model.GRADE,
                        UPSTATUS = "",
                        DNSTATUS = "NEW",
                        BID = "201"
                    };
                    _context.TBLCRMCLIENT.Add(NewClient);


                    _context.SaveChanges();
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult Detailst(string id)
        {
            if (id != null)
            {
                var Details = (from client in _context.TBLCRMCLIENT.Where(x => x.CRCID == id)
                               join groups in _context.TBLCRMGROUP
                                on client.CRGID equals groups.CRGID
                               join city in _context.TBLCITY
                               on client.CITY equals city.CTID
                               join division in _context.TBLDIVISION
                               on client.REGION equals division.DIVID
                               join country in _context.TBLCOUNTRY
                               on client.COUNTRY equals country.CNID
                               select new ClientAndGroupVM
                               {
                                   CRGNAME = groups.CRGNAME,
                                   CRGID = groups.CRGID,
                                   CRCID = client.CRCID,
                                   CRCNAME = client.CRCNAME,
                                   CRPREFIX = client.CRPREFIX,
                                   STREET = client.STREET,
                                   REGION = division.DIVNAME,
                                   CITY = city.CTNAME,
                                   COUNTRY = country.CNNAME,
                                   GRADE = client.GRADE,
                                   NOTES = client.NOTES,
                                   ABOUT = client.ABOUT,
                                   STATUS = client.STATUS,
                                   CNAME = client.CNAME,
                                   DESIGNATION = client.DESIGNATION,
                                   PHONE = client.PHONE,
                                   FAX = client.FAX,
                                   MOBILE = client.MOBILE,
                                   EMAIL = client.EMAIL,
                                   EMAILII = client.EMAILII,
                                   WEB = client.WEB,
                                   PADDRESS = client.PADDRESS

                               }).FirstOrDefault();


                return Ok(Details);
            }
            return BadRequest("id not Found");

        }

       
        [HttpDelete]
        public IActionResult Delete(ClientAndGroupVM model)
        {
            if (model.CRCID != null)
            {
                var DeleteRecord = _context.TBLCRMCLIENT.Where(x => x.CRCID == model.CRCID).FirstOrDefault();

                _context.Remove(DeleteRecord);

                _context.SaveChanges();

                return Ok("Successfully Deleted");
            }
            return BadRequest();
        }
    }
}
