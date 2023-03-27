using System;
using System.Collections.Generic;

namespace FLEXCrm.Models
{
    public partial class TBLCRMTECHMASTER
    {
        public string TMID { get; set; } = null!;
        public string? CRCID { get; set; }
        public string? PTYPE { get; set; }
        public string? SVERSION { get; set; }
        public string? SMODULE { get; set; }
        public string? OFFICEBRANCE { get; set; }
        public string? DBNAME { get; set; }
        public string? COMPREFIX { get; set; }
        public string? COMNAME { get; set; }
        public string? TITLE { get; set; }
        public string? COMADDRESS { get; set; }
        public DateTime? INSDATE { get; set; }
        public DateTime? LSTDATE { get; set; }
        public DateTime? EXPDATE { get; set; }
        public string? BACKUPLOOCATION { get; set; }
        public string? BACKUPLOOCATIONII { get; set; }
        public int? BACKUPCOPY { get; set; }
        public string? RRCOLOOCATION { get; set; }
        public string? DEMOORG { get; set; }
        public bool? ONF { get; set; }
        public bool? PG { get; set; }
        public bool? BM { get; set; }
        public bool? SL { get; set; }
        public bool? FH { get; set; }
        public bool? PB { get; set; }
        public bool? FT { get; set; }
        public bool? TL { get; set; }
        public bool? FR { get; set; }
        public bool? NW { get; set; }
        public bool? HD { get; set; }
        public bool? DW { get; set; }
        public string? LICENCENO { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string? OPTION5 { get; set; }
        public string? OPTION6 { get; set; }
        public string? OPTION7 { get; set; }
        public string? OPTION8 { get; set; }
        public string? OPTION9 { get; set; }
        public string? OPTION10 { get; set; }
        public string STATUS { get; set; } = null!;
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
