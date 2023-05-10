using System;
using System.Collections.Generic;

namespace FLEXCrm.Data
{
    public partial class TBLCRMREGION
    {
        public string DIID { get; set; } = null!;
        public string? DINAME { get; set; }
        public string? LOCATION { get; set; }
        public string? DISTANCE { get; set; }
        public string? ELEVATION { get; set; }
        public string? ABOUTDESTINATION { get; set; }
        public string? COUNTRY { get; set; }
        public string? CITY { get; set; }
        public string? NOTES { get; set; }
        public string? GLID { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string STATUS { get; set; } = null!;
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
