using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLACEXPENDITURESTATEMENT
    {
        public long SRNO { get; set; }
        public string? ACHID { get; set; }
        public string? ACHNAME { get; set; }
        public string ACSLID { get; set; } = null!;
        public string? ACSLNAME { get; set; }
        public double? DRAMT { get; set; }
        public double? CRAMT { get; set; }
        public string? STATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
