using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLACCCATEGORY
    {
        public string ACCTID { get; set; } = null!;
        public string ACCTNAME { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public string ACGID { get; set; } = null!;
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string USRID { get; set; } = null!;
        public string BID { get; set; } = null!;
    }
}
