using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLHRLEAVEREQUESTDETAILSTMP
    {
        public string LRID { get; set; } = null!;
        public string? LTID { get; set; }
        public DateTime? LVFROM { get; set; }
        public DateTime? LVTO { get; set; }
        public DateTime? LVTFROM { get; set; }
        public DateTime? LVTTO { get; set; }
        public double? DAYS { get; set; }
        public string? DESCRIPTION { get; set; }
        public int SRNO { get; set; }
        public string? OPTION1 { get; set; }
        public string? OPTION2 { get; set; }
        public string? OPTION3 { get; set; }
        public string? OPTION4 { get; set; }
        public string? OPTION5 { get; set; }
        public string? USRID { get; set; }
    }
}
