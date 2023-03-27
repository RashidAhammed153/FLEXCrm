using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLCOUNTRY
    {
        public string CNID { get; set; } = null!;
        public string CNNAME { get; set; } = null!;
        public string? COUNTRY { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? CALIAS { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string USRID { get; set; } = null!;
        public string BID { get; set; } = null!;
    }
}
