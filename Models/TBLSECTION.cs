using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLSECTION
    {
        public string SECID { get; set; } = null!;
        public string? DEPID { get; set; }
        public string? SECNAME { get; set; }
        public double? RATEF { get; set; }
        public double? RATET { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? USRID { get; set; }
        public long? ACSID { get; set; }
    }
}
