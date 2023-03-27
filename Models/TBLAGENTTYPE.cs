using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLAGENTTYPE
    {
        public string ATID { get; set; } = null!;
        public string? ATNAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? NOTES { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string STATUS { get; set; } = null!;
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
        public long? ACSID { get; set; }
    }
}
