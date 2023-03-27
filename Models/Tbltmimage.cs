using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLTMIMAGE
    {
        public string PICID { get; set; } = null!;
        public string? PRNID { get; set; }
        public string? CATID { get; set; }
        public string? IDNO { get; set; }
        public byte[]? PHOTO { get; set; }
        public long? SRNO { get; set; }
        public string? DFLT { get; set; }
        public string? PICNAME { get; set; }
        public string? PICDESCRIPTION { get; set; }
        public DateTime? DATED { get; set; }
        public string? TAKENBY { get; set; }
        public string? ALBUMNAME { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
