using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLACCLASS
    {
        public string ACCID { get; set; } = null!;
        public string ACCNAME { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public string? ACGID { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
