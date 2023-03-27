using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLDEPARTMENT
    {
        public string DEPID { get; set; } = null!;
        public string? DIVID { get; set; }
        public string? DEPNAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public int? NOSHIFT { get; set; }
        public string? PMETHOD { get; set; }
        public int? DMEMBER { get; set; }
        public int? DINCHARGE { get; set; }
        public int? DAINCHARGE { get; set; }
        public string? USRID { get; set; }
        public long? ACSID { get; set; }
    }
}
