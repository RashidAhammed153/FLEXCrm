using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLHRLEAVE
    {
        public string EID { get; set; } = null!;
        public double? ALEAVE { get; set; }
        public double? SLEAVE { get; set; }
        public double? CLEAVE { get; set; }
        public double? MLEAVE { get; set; }
        public double? PLEAVE { get; set; }
        public double? HLEAVE { get; set; }
        public double? WLEAVE { get; set; }
        public double? OLEAVE { get; set; }
        public string YEAR { get; set; } = null!;
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
