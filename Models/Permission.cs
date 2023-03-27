using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("permissions")]
    public partial class Permission
    {
        public Permission()
        {
            ModelHasPermissions = new HashSet<ModelHasPermission>();
            RoleHasPermissions = new HashSet<RoleHasPermission>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Column("guard_name")]
        [StringLength(255)]
        public string GuardName { get; set; }
        [Column("parent_id")]
        public long? ParentId { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty(nameof(ModelHasPermission.Permission))]
        public virtual ICollection<ModelHasPermission> ModelHasPermissions { get; set; }
        [InverseProperty(nameof(RoleHasPermission.Permission))]
        public virtual ICollection<RoleHasPermission> RoleHasPermissions { get; set; }
    }
}
