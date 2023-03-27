using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("model_has_roles")]
    [Index(nameof(ModelId), nameof(ModelType), Name = "model_has_roles_model_id_model_type_index")]
    public partial class ModelHasRole
    {
        [Key]
        [Column("role_id")]
        public long RoleId { get; set; }
        [Key]
        [Column("model_type")]
        [StringLength(255)]
        public string ModelType { get; set; }
        [Key]
        [Column("model_id")]
        public long ModelId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("ModelHasRoles")]
        public virtual Role Role { get; set; }
    }
}
