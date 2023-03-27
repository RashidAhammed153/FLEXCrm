using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Keyless]
    public partial class Vewuseraccesslog
    {
        [Column("USRID")]
        [StringLength(16)]
        public string Usrid { get; set; }
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
        [Column("UTYP")]
        [StringLength(50)]
        public string Utyp { get; set; }
        [Column("IPADD")]
        [StringLength(75)]
        public string Ipadd { get; set; }
        [Column("ADATE", TypeName = "datetime")]
        public DateTime? Adate { get; set; }
        [Column("ATIME")]
        [StringLength(16)]
        public string Atime { get; set; }
        [Column("ACCFROM")]
        [StringLength(50)]
        public string Accfrom { get; set; }
        [Column("OPERATION")]
        [StringLength(12)]
        public string Operation { get; set; }
        [Column("ERRORNO")]
        [StringLength(16)]
        public string Errorno { get; set; }
        [Column("ERRMSG")]
        [StringLength(250)]
        public string Errmsg { get; set; }
        [Column("BEFORE")]
        [StringLength(500)]
        public string Before { get; set; }
        [Column("AFTER")]
        [StringLength(500)]
        public string After { get; set; }
        [Column("ACSID")]
        public long Acsid { get; set; }
        [Column("OPTION1")]
        [StringLength(50)]
        public string Option1 { get; set; }
        [Column("OPTION2")]
        [StringLength(50)]
        public string Option2 { get; set; }
        [Column("OPTION3")]
        [StringLength(50)]
        public string Option3 { get; set; }
        [Column("UPSTATUS")]
        [StringLength(16)]
        public string Upstatus { get; set; }
        [Column("DNSTATUS")]
        [StringLength(16)]
        public string Dnstatus { get; set; }
        [Required]
        [Column("BID")]
        [StringLength(50)]
        public string Bid { get; set; }
        [Column("ZID")]
        [StringLength(4)]
        public string Zid { get; set; }
    }
}
