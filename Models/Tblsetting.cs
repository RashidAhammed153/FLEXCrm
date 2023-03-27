using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Keyless]
    [Table("tblsettings")]
    public partial class Tblsetting
    {
        [Column("SETTINGSID")]
        public int Settingsid { get; set; }
        [Column("SSCOMMUNICATOR")]
        public bool? Sscommunicator { get; set; }
        [Column("SSLDAP")]
        public bool? Ssldap { get; set; }
        [Column("SSSYNCHRONIZATION")]
        public bool? Sssynchronization { get; set; }
        [Column("SIDATABASE")]
        public bool? Sidatabase { get; set; }
        [Column("SIUSERS")]
        public bool? Siusers { get; set; }
        [Column("SICARDS")]
        public bool? Sicards { get; set; }
        [Column("SIDEVICE")]
        public bool? Sidevice { get; set; }
        [Column("STCOMPANY")]
        public bool? Stcompany { get; set; }
        [Column("STEMAIL")]
        public bool? Stemail { get; set; }
        [Column("STDEVICE")]
        public bool? Stdevice { get; set; }
        [Column("STSCHEDULER")]
        public bool? Stscheduler { get; set; }
        [Column("STUSERS")]
        public bool? Stusers { get; set; }
        [Column("STCOUNTER")]
        public bool? Stcounter { get; set; }
        [Column("STREGIONAL")]
        public bool? Stregional { get; set; }
        [Column("STSYSTEM")]
        public bool? Stsystem { get; set; }
        [Column("DSHAUTOLOAD")]
        public bool? Dshautoload { get; set; }
        [Column("DVCMONITORING")]
        public bool? Dvcmonitoring { get; set; }
        [Column("DVCMONITORINGTIME")]
        public int? Dvcmonitoringtime { get; set; }
        [Column("DVCMONITORINGMAIL")]
        public bool? Dvcmonitoringmail { get; set; }
        [Column("DVCMONITORINGMAILTIME")]
        public int? Dvcmonitoringmailtime { get; set; }
        [Column("DVCMONITORINGFROM", TypeName = "datetime")]
        public DateTime? Dvcmonitoringfrom { get; set; }
        [Column("DVCMONITORINGTO", TypeName = "datetime")]
        public DateTime? Dvcmonitoringto { get; set; }
        [Column("DVCERRORLOG")]
        public bool? Dvcerrorlog { get; set; }
        [Column("DVCACCESSLOG")]
        public bool? Dvcaccesslog { get; set; }
        [Column("DVCUSERBASEDATA")]
        public bool? Dvcuserbasedata { get; set; }
        [Column("DVCAUTOMAIL")]
        public bool? Dvcautomail { get; set; }
        [Column("DAILYCOUNTER")]
        public bool? Dailycounter { get; set; }
        [Column("DAILYCOUNTERTIME")]
        public int? Dailycountertime { get; set; }
        [Column("DAILYCOUNTERFROM", TypeName = "datetime")]
        public DateTime? Dailycounterfrom { get; set; }
        [Column("DAILYCOUNTERTO", TypeName = "datetime")]
        public DateTime? Dailycounterto { get; set; }
        [Column("ETERMINAL")]
        public int? Eterminal { get; set; }
        [Column("HTERMINAL")]
        public int? Hterminal { get; set; }
        [Column("MTERMINAL")]
        public int? Mterminal { get; set; }
        [Column("SPOOLER")]
        public int? Spooler { get; set; }
        [Column("USERS")]
        public int? Users { get; set; }
        [Column("SCHEDULER")]
        public int? Scheduler { get; set; }
        [Column("SCAN")]
        public bool? Scan { get; set; }
        [Column("FAX")]
        public bool? Fax { get; set; }
        [Column("A3DLT")]
        public bool? A3dlt { get; set; }
        [Column("DUPLEX")]
        public bool? Duplex { get; set; }
    }
}
