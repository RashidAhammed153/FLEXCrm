using System;
using System.Collections.Generic;

namespace FLEXCrm.Models
{
    public partial class TBLCRMTECHAMC
    {
        public string TAID { get; set; } = null!;
        public string TMID { get; set; } = null!;
        public DateTime? AUPDATE { get; set; }
        public string? OLICENCE { get; set; }
        public string? OLSTATUS { get; set; }
        public bool? FR { get; set; }
        public bool? NW { get; set; }
        public bool? HD { get; set; }
        public bool? DW { get; set; }
        public bool? ONF { get; set; }
        public bool? PG { get; set; }
        public bool? BM { get; set; }
        public bool? SL { get; set; }
        public bool? FH { get; set; }
        public bool? PB { get; set; }
        public bool? FT { get; set; }
        public bool? TL { get; set; }
        public string? PTYPE { get; set; }
        public string? SWVERSION { get; set; }
        public string? NLICENCE { get; set; }
        public DateTime? RDATE { get; set; }
        public DateTime? EDATE { get; set; }
        public double? QUANTITY { get; set; }
        public double? SPRICE { get; set; }
        public double? DISCOUNT { get; set; }
        public double? TDS { get; set; }
        public double? TOTAL { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string? OPTION5 { get; set; }
        public DateTime? CDATE { get; set; }
        public DateTime? UDATE { get; set; }
        public string STATUS { get; set; } = null!;
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
