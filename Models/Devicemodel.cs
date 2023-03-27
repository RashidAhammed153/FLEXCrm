using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Keyless]
    [Table("devicemodel")]
    public partial class Devicemodel
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("modelno")]
        [StringLength(150)]
        public string Modelno { get; set; }
        [Column("description")]
        [StringLength(250)]
        public string Description { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
    }
}
