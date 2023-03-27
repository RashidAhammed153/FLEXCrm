using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLEMAILSETTING
    {
        public string ESETNAME { get; set; } = null!;
        public string? ESETDETAILS { get; set; }
        public string? OUTGOINGMAILSERVER { get; set; }
        public string? PORTNO { get; set; }
        public string? MAILTO { get; set; }
        public string? MAILFROM { get; set; }
        public string? MAILPASS { get; set; }
        public string? DISPLAYNAME { get; set; }
        public bool? USERDEFAULT { get; set; }
        public bool? ENABLESSL { get; set; }
        public string? DEFAULTID { get; set; }
        public string? SENDBY { get; set; }
        public string? SENDFROM { get; set; }
        public string? SENDCRITERIA { get; set; }
        public string? SENDDATETIME { get; set; }
        public string? MSGTYPE { get; set; }
        public string? MSGFORMAT { get; set; }
        public string? MSGPRIORITY { get; set; }
        public string? MSGNOTES { get; set; }
        public string? MSGSCHEUDLETIME { get; set; }
        public bool? MSGSCHEDULE { get; set; }
        public string? STATUS { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
        public long SRNO { get; set; }
    }
}
