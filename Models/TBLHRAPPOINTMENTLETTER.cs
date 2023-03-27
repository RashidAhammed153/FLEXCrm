using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLHRAPPOINTMENTLETTER
    {
        public string TRID { get; set; } = null!;
        public string TRNAME { get; set; } = null!;
        public int? SRNO { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string OPTION5 { get; set; } = null!;
        public string? STATUS { get; set; }
        public string? EID { get; set; }
        public string? SUSRID { get; set; }
        public string? ADMREF { get; set; }
        public int? PMONTH { get; set; }
        public DateTime? CNDATE { get; set; }
        public bool? HoD { get; set; }
        public bool? HR { get; set; }
        public bool? GM { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
