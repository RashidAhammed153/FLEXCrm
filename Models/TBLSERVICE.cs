using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLSERVICE
    {
        public string SVID { get; set; } = null!;
        public string SVNAME { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public string? REVUNDER { get; set; }
        public string? ISBILLABLE { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public long? BID { get; set; }
    }
}
