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

        [HttpGet("DeviceList")]
        public IActionResult DeviceList()
        {
            return Ok("DeviceList");
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Ok("DeviceList");
        }
    }
}
