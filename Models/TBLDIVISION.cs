using System;
using System.Collections.Generic;

namespace FLEXCrm.Models
{
    public partial class TBLDIVISION
    {
        public string DIVID { get; set; } = null!;
        public string? DIVNAME { get; set; }
        public string? DIVNAMEB { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? ISOCODE { get; set; }
        public int? ESTABLISH { get; set; }
        public int? DISTRICTS { get; set; }
        public int? UPZILAS { get; set; }
        public int? UNIONCOUNCILS { get; set; }
        public string? USRID { get; set; }
    }
}
