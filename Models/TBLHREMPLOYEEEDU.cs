using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLHREMPLOYEEEDU
    {
        public string EDID { get; set; } = null!;
        public string DCNAME { get; set; } = null!;
        public int? COPIES { get; set; }
        public string? ORIGINAL { get; set; }
        public string? PHOTOCOPY { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? EID { get; set; }
        public byte[]? DCPHOTO { get; set; }
        public int? SRNO { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string? OPTION5 { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
