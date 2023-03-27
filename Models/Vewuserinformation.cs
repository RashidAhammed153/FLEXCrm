using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Keyless]
    public partial class Vewuserinformation
    {
        [Column("GRPID")]
        [StringLength(8)]
        public string Grpid { get; set; }
        [Required]
        [Column("GRPNAME")]
        [StringLength(50)]
        public string Grpname { get; set; }
        [Required]
        [Column("EID")]
        [StringLength(8)]
        public string Eid { get; set; }
        [Required]
        [Column("UNAME")]
        [StringLength(75)]
        public string Uname { get; set; }
        [Column("DEPARTMENT")]
        [StringLength(50)]
        public string Department { get; set; }
        [Column("DESIGNATION")]
        [StringLength(50)]
        public string Designation { get; set; }
        [Column("ADDRESS")]
        [StringLength(250)]
        public string Address { get; set; }
        [Column("PHONE")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Column("MOBILE")]
        [StringLength(50)]
        public string Mobile { get; set; }
        [Column("FAX")]
        [StringLength(50)]
        public string Fax { get; set; }
        [Column("EMAIL")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("BDATE")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? Bdate { get; set; }
        [Column("JDATE")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? Jdate { get; set; }
        [Column("NOTES")]
        [StringLength(500)]
        public string Notes { get; set; }
        [Required]
        [Column("USRID")]
        [StringLength(16)]
        public string Usrid { get; set; }
        [Column("UTYP")]
        [StringLength(50)]
        public string Utyp { get; set; }
        [Column("PASSWORD")]
        [StringLength(16)]
        public string Password { get; set; }
        [Column("PHINT")]
        [StringLength(150)]
        public string Phint { get; set; }
        [Column("STATUS")]
        [StringLength(8)]
        public string Status { get; set; }
        [Column("SOPT")]
        [StringLength(50)]
        public string Sopt { get; set; }
        [Column("ROPT")]
        [StringLength(50)]
        public string Ropt { get; set; }
        [Column("OPT1")]
        [StringLength(50)]
        public string Opt1 { get; set; }
        [Column("OPT2")]
        [StringLength(500)]
        public string Opt2 { get; set; }
        [Column("OPT3")]
        [StringLength(50)]
        public string Opt3 { get; set; }
        [Column("OPT4")]
        [StringLength(50)]
        public string Opt4 { get; set; }
        [Column("OPT5")]
        [StringLength(50)]
        public string Opt5 { get; set; }
        [Column("OPT6")]
        public bool? Opt6 { get; set; }
        [Column("OPT7")]
        public bool? Opt7 { get; set; }
        [Column("OPT8")]
        public bool? Opt8 { get; set; }
        [Column("OPT9")]
        public bool? Opt9 { get; set; }
        [Column("OPT10")]
        public bool? Opt10 { get; set; }
        [Column("RV")]
        public bool? Rv { get; set; }
        [Column("FO")]
        public bool? Fo { get; set; }
        [Column("RS")]
        public bool? Rs { get; set; }
        [Column("ST")]
        public bool? St { get; set; }
        [Column("KT")]
        public bool? Kt { get; set; }
        [Column("SP")]
        public bool? Sp { get; set; }
        [Column("HR")]
        public bool? Hr { get; set; }
        [Column("HK")]
        public bool? Hk { get; set; }
        [Column("CF")]
        public bool? Cf { get; set; }
        [Column("BN")]
        public bool? Bn { get; set; }
        [Column("BT")]
        public bool? Bt { get; set; }
        [Column("XM")]
        public bool? Xm { get; set; }
        [Column("AC")]
        public bool? Ac { get; set; }
        [Column("BE")]
        public bool? Be { get; set; }
        [Column("CM")]
        public bool? Cm { get; set; }
        [Column("GD")]
        public bool? Gd { get; set; }
        [Column("RM")]
        public bool? Rm { get; set; }
        [Column("ONLINE")]
        public bool? Online { get; set; }
        [Column("PAUTHORIZATION")]
        public bool? Pauthorization { get; set; }
        [Column("IAUTHORIZATION")]
        public bool? Iauthorization { get; set; }
        [Column("SUBSTORE")]
        public bool? Substore { get; set; }
        [Column("RESERVATIONHOLD")]
        public bool? Reservationhold { get; set; }
        [Column("TALLYAUTHORIZATION")]
        public bool? Tallyauthorization { get; set; }
        [Column("UPSTATUS")]
        [StringLength(12)]
        public string Upstatus { get; set; }
        [Column("DNSTATUS")]
        [StringLength(12)]
        public string Dnstatus { get; set; }
        [Column("CUSRID")]
        [StringLength(16)]
        public string Cusrid { get; set; }
        [Column("BID")]
        [StringLength(16)]
        public string Bid { get; set; }
        [Column("PHOTO", TypeName = "image")]
        public byte[] Photo { get; set; }
    }
}
