using System;
using System.Collections.Generic;

namespace FLEXCrm.DEMODATA
{
    public partial class TBLSYNCDETAIL
    {
        public string? SYNCID { get; set; }
        public long? SRNO { get; set; }
        public string? SOURCETABLE { get; set; }
        public string? SOURCEDESCRIPTION { get; set; }
        public double? SOURCETOTAL { get; set; }
        public string? SOURCESTATUS { get; set; }
        public string? DESTTABLE { get; set; }
        public double? DESTTOTAL { get; set; }
        public string? DESTSTATUS { get; set; }
        public string? REMARKS { get; set; }
        public bool? YN { get; set; }
        public int? TC { get; set; }
    }
}
