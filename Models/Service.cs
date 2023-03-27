using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("service")]
    public partial class Service
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("label")]
        [StringLength(100)]
        public string Label { get; set; }
        [Column("category_id")]
        public int? CategoryId { get; set; }
        [Column("status")]
        public byte? Status { get; set; }
        [Column("price")]
        public double? Price { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
    }
}
