using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLEXPORTTALLYSETTING
    {
        public long TSID { get; set; }
        public string? TSCATEGORY { get; set; }
        public string? FLXNAME { get; set; }
        public string? TALLYNAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public string DRCR { get; set; } = null!;
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
