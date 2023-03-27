using System;
using System.Collections.Generic;

namespace FLEXCrm.Models
{
    public partial class TBLUSERINFO
    {
        public string EID { get; set; } = null!;
        public string UNAME { get; set; } = null!;
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
        public string? SOPT { get; set; }
        public string? ROPT { get; set; }
        public string? OPT1 { get; set; }
        public string? OPT2 { get; set; }
        public string? OPT3 { get; set; }
        public string? OPT4 { get; set; }
        public string? OPT5 { get; set; }
        public bool? OPT6 { get; set; }
        public bool? OPT7 { get; set; }
        public bool? OPT8 { get; set; }
        public bool? OPT9 { get; set; }
        public bool? OPT10 { get; set; }
        public bool? RV { get; set; }
        public bool? FO { get; set; }
        public bool? RS { get; set; }
        public bool? ST { get; set; }
        public bool? KT { get; set; }
        public bool? SP { get; set; }
        public bool? HR { get; set; }
        public bool? HK { get; set; }
        public bool? CF { get; set; }
        public bool? BN { get; set; }
        public bool? BT { get; set; }
        public bool? XM { get; set; }
        public bool? AC { get; set; }
        public bool? BE { get; set; }
        public bool? CM { get; set; }
        public bool? GD { get; set; }
        public bool? RM { get; set; }
        public bool? ONLINE { get; set; }
        public bool? PAUTHORIZATION { get; set; }
        public bool? IAUTHORIZATION { get; set; }
        public bool? SUBSTORE { get; set; }
        public bool? RESERVATIONHOLD { get; set; }
        public bool? TALLYAUTHORIZATION { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? CUSRID { get; set; }
        public string? BID { get; set; }
    }
}
