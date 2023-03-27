using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLCRMTECHDETAIL
    {
        public string TDID { get; set; } = null!;
        public string TMID { get; set; } = null!;
        public string? SWTYPE { get; set; }
        public string? SWNAME { get; set; }
        public string? SWVERSION { get; set; }
        public string? CUSRID { get; set; }
        public string? CUSRPASS { get; set; }
        public string? TVRID { get; set; }
        public string? TVRPASS { get; set; }
        public string? IPADD { get; set; }
        public string? SUBNET { get; set; }
        public string? DGATEWAY { get; set; }
        public string? PDNS { get; set; }
        public string? SDNS { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string? OPTION5 { get; set; }
        public DateTime? CDATE { get; set; }
        public DateTime? UDATE { get; set; }
        public string STATUS { get; set; } = null!;
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
