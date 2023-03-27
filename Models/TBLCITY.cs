using System;
using System.Collections.Generic;

namespace FLEXCrm.Models
{
    public partial class TBLCITY
    {
        public string CTID { get; set; } = null!;
        public string? CTNAME { get; set; }
        public string CNID { get; set; } = null!;
        public string? CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? ALIASS { get; set; }
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
