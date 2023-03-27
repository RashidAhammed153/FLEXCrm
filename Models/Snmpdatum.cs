﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("snmpdata")]
    public partial class Snmpdatum
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("status")]
        public byte? Status { get; set; }
        [Column("sts")]
        [StringLength(50)]
        public string Sts { get; set; }
        [Column("color")]
        [StringLength(100)]
        public string Color { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
    }
}
