using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLHRSCHARGE
    {
        public long? SCID { get; set; }
        public string EID { get; set; } = null!;
        public string? DPNAME { get; set; }
        public string? DSNAME { get; set; }
        public double? GRSCHARGE { get; set; }
        public double? MODAY { get; set; }
        public double? MPRESENT { get; set; }
        public double? MABSENT { get; set; }
        public double? GRSDEDUCTION { get; set; }
        public double? NETPAYABLE { get; set; }
        public string SMONTH { get; set; } = null!;
        public string SYEAR { get; set; } = null!;
        public DateTime? SDATED { get; set; }
        public string? VTYPE { get; set; }
        public string? VNO { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string? OPTION5 { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
