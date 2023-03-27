using System;
using System.Collections.Generic;

namespace FLEXCrm.Models
{
    public partial class TBLCRMTEAM
    {
        public string EMPID { get; set; } = null!;
        public string EMPNAME { get; set; } = null!;
        public string? DEPARTMENT { get; set; }
        public string? DESIGNATION { get; set; }
        public string? ADDRESS { get; set; }
        public string? PHONE { get; set; }
        public string? MOBILE { get; set; }
        public string? FAX { get; set; }
        public string? EMAIL { get; set; }
        public DateTime? BDATE { get; set; }
        public DateTime? JDATE { get; set; }
        public string? NOTES { get; set; }
        public byte[]? PHOTO { get; set; }
        public string USRID { get; set; } = null!;
        public string? GRPID { get; set; }
        public string? UTYP { get; set; }
        public string? PASSWORD { get; set; }
        public string? PHINT { get; set; }
        public string? STATUS { get; set; }
        public string? OPT1 { get; set; }
        public string? OPT2 { get; set; }
        public string? OPT3 { get; set; }
        public string? OPT4 { get; set; }
        public string? OPT5 { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? CUSRID { get; set; }
        public string? BID { get; set; }
    }
}
