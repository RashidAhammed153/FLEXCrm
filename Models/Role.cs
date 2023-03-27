using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("roles")]
    public partial class Role
    {
        public Role()
        {
            ModelHasRoles = new HashSet<ModelHasRole>();
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
        [Column("status")]
        public byte? Status { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty(nameof(ModelHasRole.Role))]
        public virtual ICollection<ModelHasRole> ModelHasRoles { get; set; }
        [InverseProperty(nameof(RoleHasPermission.Role))]
        public virtual ICollection<RoleHasPermission> RoleHasPermissions { get; set; }
    }
}
