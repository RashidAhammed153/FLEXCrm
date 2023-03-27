using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLUSERACCESSLOG
    {
        public string? USRID { get; set; }
        public string? IPADD { get; set; }
        public DateTime? ADATE { get; set; }
        public string? ATIME { get; set; }
        public string? ACCFROM { get; set; }
        public string? OPERATION { get; set; }
        public string? ERRORNO { get; set; }
        public string? ERRMSG { get; set; }
        public string? BEFORE { get; set; }
        public string? AFTER { get; set; }
        public long ACSID { get; set; }
        public string? BID { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
    }
}
