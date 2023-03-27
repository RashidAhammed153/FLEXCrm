using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Keyless]
    public partial class Vewuserprivelege
    {
        [Column("GRPID")]
        [StringLength(3)]
        public string Grpid { get; set; }
        [Required]
        [Column("GRPNAME")]
        [StringLength(50)]
        public string Grpname { get; set; }
        [Column("USRID")]
        [StringLength(16)]
        public string Usrid { get; set; }
        [Column("PRVID")]
        [StringLength(8)]
        public string Prvid { get; set; }
        [Column("FRMNAME")]
        [StringLength(50)]
        public string Frmname { get; set; }
        [Column("FRMTITILE")]
        [StringLength(50)]
        public string Frmtitile { get; set; }
        [Column("FRMMENU")]
        [StringLength(50)]
        public string Frmmenu { get; set; }
        [Column("FRMACCESS")]
        public bool? Frmaccess { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(250)]
        public string Description { get; set; }
        [Column("PSAVE")]
        public bool? Psave { get; set; }
        [Column("PEDIT")]
        public bool? Pedit { get; set; }
        [Column("PDELETE")]
        public bool? Pdelete { get; set; }
        [Column("PPRINT")]
        public bool? Pprint { get; set; }
        [Column("PEXPORT")]
        public bool? Pexport { get; set; }
        [Column("PHELP")]
        public bool? Phelp { get; set; }
        [Column("PPICTURE")]
        public bool? Ppicture { get; set; }
        [Column("POPTION1")]
        public bool? Poption1 { get; set; }
        [Column("POPTION2")]
        public bool? Poption2 { get; set; }
        [Column("POPTION3")]
        public bool? Poption3 { get; set; }
        [Column("POPTION4")]
        [StringLength(3)]
        public string Poption4 { get; set; }
        [Column("POPTION5")]
        [StringLength(250)]
        public string Poption5 { get; set; }
        [Column("SRNO")]
        public long? Srno { get; set; }
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
        [Column("STATUS")]
        [StringLength(8)]
        public string Status { get; set; }
        [Required]
        [Column("EID")]
        [StringLength(8)]
        public string Eid { get; set; }
    }
}
