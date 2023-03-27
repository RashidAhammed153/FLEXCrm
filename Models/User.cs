using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("users")]
    [Index(nameof(Email), Name = "users_email_unique", IsUnique = true)]
    public partial class User
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; }
        [Column("contact_number")]
        [StringLength(255)]
        public string ContactNumber { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Required]
        [Column("user_type")]
        [StringLength(255)]
        public string UserType { get; set; }
        [Column("gender")]
        [StringLength(255)]
        public string Gender { get; set; }
        [Column("provider")]
        [StringLength(255)]
        public string Provider { get; set; }
        [Column("provider_unique_id")]
        [StringLength(255)]
        public string ProviderUniqueId { get; set; }
        [Column("email_verified_at", TypeName = "datetime")]
        public DateTime? EmailVerifiedAt { get; set; }
        [Column("remember_token")]
        [StringLength(100)]
        public string RememberToken { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
    }
}
