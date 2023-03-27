using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLUSERGROUP
    {
        public string GRPID { get; set; } = null!;
        public string GRPNAME { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public string? NOTES { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
