using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("role_has_permissions")]
    public partial class RoleHasPermission
    {
        [Key]
        [Column("permission_id")]
        public long PermissionId { get; set; }
        [Key]
        [Column("role_id")]
        public long RoleId { get; set; }

        [ForeignKey(nameof(PermissionId))]
        [InverseProperty("RoleHasPermissions")]
        public virtual Permission Permission { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("RoleHasPermissions")]
        public virtual Role Role { get; set; }
    }
}
