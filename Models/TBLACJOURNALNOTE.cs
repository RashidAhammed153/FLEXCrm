using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLACJOURNALNOTE
    {
        public string JNID { get; set; } = null!;
        public DateTime? JNDATE { get; set; }
        public string? JNSTATUS { get; set; }
        public long? JNSRNO { get; set; }
        public long TRNID { get; set; }
        public DateTime? TRANDATE { get; set; }
        public string? VTYPE { get; set; }
        public string? VNO { get; set; }
        public string? SHOW { get; set; }
        public long? SRNO { get; set; }
        public string? CDPTYPE { get; set; }
        public string? CHQ { get; set; }
        public string? ACCID { get; set; }
        public string? ACCNAME { get; set; }
        public double? DRAMT { get; set; }
        public double? CRAMT { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? CSTID { get; set; }
        public string? NARRATION { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? JNOPTION1 { get; set; }
        public string? JNOPTION2 { get; set; }
        public string? JNOPTION3 { get; set; }
        public string? JNOPTION4 { get; set; }
        public string? JNOPTION5 { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
