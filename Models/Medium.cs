using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("media")]
    [Index(nameof(ModelType), nameof(ModelId), Name = "media_model_type_model_id_index")]
    public partial class Medium
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("model_type")]
        [StringLength(255)]
        public string ModelType { get; set; }
        [Column("model_id")]
        public long ModelId { get; set; }
        [Required]
        [Column("collection_name")]
        [StringLength(255)]
        public string CollectionName { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Column("file_name")]
        [StringLength(255)]
        public string FileName { get; set; }
        [Column("mime_type")]
        [StringLength(255)]
        public string MimeType { get; set; }
        [Required]
        [Column("disk")]
        [StringLength(255)]
        public string Disk { get; set; }
        [Column("size")]
        public long Size { get; set; }
        [Required]
        [Column("manipulations")]
        public string Manipulations { get; set; }
        [Required]
        [Column("custom_properties")]
        public string CustomProperties { get; set; }
        [Required]
        [Column("responsive_images")]
        public string ResponsiveImages { get; set; }
        [Column("order_column")]
        public int? OrderColumn { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
    }
}
