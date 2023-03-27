using System;
using System.Collections.Generic;

namespace FLEXCrm.Models
{
    public partial class TBLCRMCLIENT
    {
        public string CRCID { get; set; } = null!;
        public string? CRCNAME { get; set; }
        public string? CRPREFIX { get; set; }
        public string CRGID { get; set; } = null!;
        public string? STREET { get; set; }
        public string? CITY { get; set; }
        public string? REGION { get; set; }
        public string? STATE { get; set; }
        public string? COUNTRY { get; set; }
        public string? CNAME { get; set; }
        public string? DESIGNATION { get; set; }
        public string? PHONE { get; set; }
        public string? FAX { get; set; }
        public string? MOBILE { get; set; }
        public string? EMAIL { get; set; }
        public string? EMAILII { get; set; }
        public string? WEB { get; set; }
        public string? PADDRESS { get; set; }
        public string? GRADE { get; set; }
        public string? ABOUT { get; set; }
        public string? NOTES { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string? OPTION5 { get; set; }
        public DateTime? CDATE { get; set; }
        public DateTime? UDATE { get; set; }
        public byte[] CLOGO { get; set; } = null!;
        public string STATUS { get; set; } = null!;
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
