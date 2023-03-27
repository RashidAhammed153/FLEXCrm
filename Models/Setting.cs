using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("setting")]
    [Index(nameof(Key), Name = "settings_key_index")]
    public partial class Setting
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("type")]
        [StringLength(255)]
        public string Type { get; set; }
        [Required]
        [Column("key")]
        [StringLength(255)]
        public string Key { get; set; }
        [Column("value")]
        public string Value { get; set; }
    }
}
