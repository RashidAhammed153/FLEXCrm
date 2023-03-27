using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Keyless]
    public partial class Vewcm
    {
        [Column("COMID")]
        public int Comid { get; set; }
        [Column("CMNAME")]
        [StringLength(100)]
        public string Cmname { get; set; }
        [Column("CMTITILE")]
        [StringLength(150)]
        public string Cmtitile { get; set; }
        [Column("CMADDRESS")]
        [StringLength(250)]
        public string Cmaddress { get; set; }
        [Column("CMCOUNTRY")]
        [StringLength(50)]
        public string Cmcountry { get; set; }
        [Column("CMCITY")]
        [StringLength(50)]
        public string Cmcity { get; set; }
        [Column("CMPHONE")]
        [StringLength(75)]
        public string Cmphone { get; set; }
        [Column("CMFAX")]
        [StringLength(75)]
        public string Cmfax { get; set; }
        [Column("CMEMAIL")]
        [StringLength(150)]
        public string Cmemail { get; set; }
        [Column("CMLOGO", TypeName = "image")]
        public byte[] Cmlogo { get; set; }
        [Column("CMPOSWEREDBY")]
        [StringLength(500)]
        public string Cmposweredby { get; set; }
    }
}
