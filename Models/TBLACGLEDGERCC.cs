using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLACGLEDGERCC
    {
        public long? SRNO { get; set; }
        public DateTime? TRANDATE { get; set; }
        public string? VNO { get; set; }
        public string? VTYPE { get; set; }
        public string? CHQ { get; set; }
        public string ACCID { get; set; } = null!;
        public string? ACCNAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public double? OPBAL { get; set; }
        public double? DRAMT { get; set; }
        public double? CRAMT { get; set; }
        public double? CLBAL { get; set; }
        public string? SHOW { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
        public long? TRNID { get; set; }
    }
}
