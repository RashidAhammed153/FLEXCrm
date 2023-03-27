using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("model_has_permissions")]
    [Index(nameof(ModelId), nameof(ModelType), Name = "model_has_permissions_model_id_model_type_index")]
    public partial class ModelHasPermission
    {
        [Key]
        [Column("permission_id")]
        public long PermissionId { get; set; }
        [Key]
        [Column("model_type")]
        [StringLength(255)]
        public string ModelType { get; set; }
        [Key]
        [Column("model_id")]
        public long ModelId { get; set; }

        [ForeignKey(nameof(PermissionId))]
        [InverseProperty("ModelHasPermissions")]
        public virtual Permission Permission { get; set; }
    }
}
