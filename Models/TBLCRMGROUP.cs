using System;
using System.Collections.Generic;

namespace FLEXCrm.Models
{
    public partial class TBLCRMGROUP
    {
        public string CRGID { get; set; } = null!;
        public string CRGNAME { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public string STATUS { get; set; } = null!;
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
