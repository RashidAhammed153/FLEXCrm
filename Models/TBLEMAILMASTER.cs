using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLEMAILMASTER
    {
        public long SRNO { get; set; }
        public string? MAILSUB { get; set; }
        public string? MAILMENTION { get; set; }
        public string? MAILHEADER { get; set; }
        public string? MAILBODY { get; set; }
        public string? MAILBY { get; set; }
        public string? MAILNOTES { get; set; }
        public string? MAILFOOTER { get; set; }
        public string? SOCIAL1 { get; set; }
        public string? SOCIAL2 { get; set; }
        public string? SOCIAL3 { get; set; }
        public string? SOCIAL4 { get; set; }
        public string? SOCIAL5 { get; set; }
        public string? SOCIAL6 { get; set; }
        public string? SOCIAL7 { get; set; }
        public string? SOCIAL8 { get; set; }
        public string? SOCIAL9 { get; set; }
        public string? SOCIAL10 { get; set; }
        public string? DISCLAIMER { get; set; }
        public string? MSGTYPE { get; set; }
        public string? MSGFORMAT { get; set; }
        public string? MSGPRIORITY { get; set; }
        public bool? MSGSCHEDULE { get; set; }
        public string? MSGSCHEUDLETIME { get; set; }
        public string ESETNAME { get; set; } = null!;
        public string ESETDETAILS { get; set; } = null!;
        public string? SENDFROM { get; set; }
        public string? SENDTO { get; set; }
        public string? SENDCC { get; set; }
        public string? SENDBCC { get; set; }
        public string? SENDCRITERIA { get; set; }
        public string? SENDDATETIME { get; set; }
        public string? OUTGOINGMAILSERVER { get; set; }
        public string? PORTNO { get; set; }
        public string? MAILFROM { get; set; }
        public string? MAILPASS { get; set; }
        public bool? USERDEFAULT { get; set; }
        public bool? ENABLESSL { get; set; }
        public string? STATUS { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string? OPTION5 { get; set; }
        public DateTime? CREATEDATE { get; set; }
        public DateTime? UPDATEDATE { get; set; }
        public string? UPSTATUS { get; set; }
        public string? DNSTATUS { get; set; }
        public string? USRID { get; set; }
        public string? BID { get; set; }
    }
}
