using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using FLEXCrm.Data;
using MimeKit;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FLEXBDContext _context;
        public IConfiguration Configuration { get; }

        public HomeController(ILogger<HomeController> logger,
            FLEXBDContext context,
            IConfiguration configuration)
        {
            _logger = logger;
            _context = context;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return Ok();
        }

        public async Task<IActionResult> Dashboard()
        {

            return Ok();
        }

        public IActionResult Login(bool isSuccess = false)
        {
            return Ok();
        }

        //public IActionResult MailRequest()
        //{
        //    var message = new MimeMessage();
        //    message.From.Add(new MailboxAddress("SDM", "hello@flexinfosys.com"));
        //    message.To.Add(new MailboxAddress("Info", "info@flexinfosys.com"));
        //    message.Subject = "SDM Confirmation";
        //    message.Body = new TextPart("Plain")
        //    {
        //        Text = "This is confirmation mail"
        //    };

        //    using (var client = new SmtpClient())
        //    {
        //        client.Connect("mail.flexinfosys.com", 587, false);
        //        client.Authenticate("hello@flexinfosys.com", "g3no7P@6");
        //        client.Send(message);
        //        client.Disconnect(true);
        //    }

        //    return Ok();
        //}
        public IActionResult Chart()
        {
            return Ok();
        }
        //public JsonResult GetDashboardChart()
        //{
        //    List<Vewpscntmaster> cntData;
        //    DateTime startDate = (DateTime)_context.Vewpscntmasters.Max(m => m.Cntdate);

        //    try
        //    {
        //        cntData = _context.Vewpscntmasters.Where(p => p.Cntmonth == startDate.ToString("MMMM")).ToList();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return Json(cntData);
        //}
        public class DeviceStatus
        {
            public int Value { get; set; }
            public string Data { get; set; }
        }
        //public JsonResult GetMonitoringChart()
        //{
        //    Vewpsdevicestatussum cntData;
        //    cntData = _context.Vewpsdevicestatussums.FirstOrDefault();

        //    var deptList = new List<DeviceStatus>()
        //    {
        //        new DeviceStatus() { Value = int.Parse(cntData.Dvproductive.ToString()), Data= "Productive" },
        //        new DeviceStatus() { Value = int.Parse(cntData.Dvserror.ToString()), Data= "Critical Error" },
        //        new DeviceStatus() { Value = int.Parse(cntData.Dvsdisconnected.ToString()), Data= "Disconnected" },
        //        new DeviceStatus() { Value = int.Parse(cntData.Dvjstatus.ToString()), Data= "Paper Misfeed" },
        //        new DeviceStatus() { Value = int.Parse(cntData.Dvcocover.ToString()), Data= "Cover Open" },
        //        new DeviceStatus() { Value = int.Parse(cntData.Dvpstatus2.ToString()), Data= "Out of Paper" }
        //    };

        //    var opt = new JsonSerializerOptions() { WriteIndented = true };
        //    string strJson = JsonSerializer.Serialize<IList<DeviceStatus>>(deptList, opt);

        //    return Json(deptList);
        //}

        public IActionResult Viewer()
        {
            return Ok();
        }

        [HttpGet("{ctrl}/{acn}/{cntMonth}/{cntYear}/{cntDate}/{rptRef}/{rptNo}")]
        public IActionResult Viewer(string ctrl, string acn, string cntMonth, string cntYear, string cntDate, string rptRef, int rptNo, bool isSuccess = false)
        {
            String qSQL = "";
            DateTime date = DateTime.Parse(cntDate.ToString());

            if (rptNo == 0 || rptNo == 1)
            {
                qSQL = "SELECT * FROM VEWPSDEVICE ORDER BY BUILDING, FLOOR, DEPARTMENT";
                isSuccess = true;
            }
            else if (rptNo == 2)
            {
                qSQL = "SELECT * FROM VEWPSDEVICESTATUS WHERE DVSSTATUS<>'Ready' ORDER BY BUILDING, FLOOR, DEPARTMENT";
                isSuccess = true;
            }
            else if (rptNo == 3)
            {
                if (rptRef != "1")
                {
                    qSQL = "SELECT * FROM VEWPSDETAILS WHERE CNTMONTH='" + cntMonth.ToString() + "' AND CNTYEAR='" + cntYear.ToString() + "' AND CNTSR='" + rptRef.ToString() + "'";
                }
                else
                {
                    qSQL = "SELECT * FROM VEWPSDETAILS WHERE CNTMONTH='" + cntMonth.ToString() + "' AND CNTYEAR='" + cntYear.ToString() + "' AND CNTDATE='" + date.ToString("dd-MMM-yy") + "'";
                }
                isSuccess = true;
            }
            else if (rptNo == 4)
            {
                qSQL = "SELECT * FROM VEWPSDEVICE ORDER BY BUILDING, FLOOR, DEPARTMENT";
                isSuccess = true;
            }
            else if (rptNo == 5)    // LIST OF SCHEDULER
            {
                qSQL = "SELECT * FROM VEWPSDEVICESTATUS ORDER BY BUILDING, FLOOR, DEPARTMENT";
                isSuccess = true;
            }
            else if (rptNo == 51)    // SCHEDULER INFORMATION
            {
                qSQL = "SELECT * FROM VEWPSDEVICESTATUS ORDER BY BUILDING, FLOOR, DEPARTMENT";
                isSuccess = true;
            }
            else if (rptNo == 6)    // COMPANY INFORMATION
            {
                qSQL = "SELECT * FROM VEWPSDETAILS WHERE CNTMONTH='June' AND CNTYEAR='2021' AND CNTDATE='2021-06-01'";
                isSuccess = true;
            }
            else if (rptNo == 7)    // LIST OF USER
            {
                qSQL = "SELECT * FROM VEWPSDETAILS WHERE CNTMONTH='June' AND CNTYEAR='2021' AND CNTDATE='2021-06-01'";
                isSuccess = true;
            }
            else if (rptNo == 71)   // USER INFORMATION
            {
                qSQL = "SELECT * FROM VEWPSDETAILS WHERE CNTMONTH='June' AND CNTYEAR='2021' AND CNTDATE='2021-06-01'";
                isSuccess = true;
            }
            else if (rptNo == 8)   // SNMP DATA
            {
                qSQL = "SELECT * FROM TBLDATAVALUE";
                isSuccess = true;
            }

            //ViewBag.IsSuccess = isSuccess;
            //ViewBag.aPram = qSQL;
            //ViewBag.MyRpt = rptNo;

            return Ok("Viewer");
        }

        public async Task<IActionResult> Monitoring(int pg = 1, string searchKey = "")
        {

            return Ok();
        }

        public async Task<IActionResult> Counter(int pg = 1, string searchKey = "")
        {

            return Ok();
        }

        public IActionResult Privacy()
        {
            return Ok();
        }

        public IActionResult Contact()
        {
            return Ok();
        }

        public IActionResult DeviceList()
        {
            return Ok("DeviceList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Ok("DeviceList");
        }
    }
}
