using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FLEXCrm.Models
{
    public class TBLCRMTECHDETAILS
    {
        [Key]
        [Column("TDID")]
        [StringLength(4)]
        public string TDID { get; set; }
        [Column("TMID")]
        [StringLength(6)]
        public string TMID { get; set; }
        [Column("SWTYPE")]
        [StringLength(50)]
        public string SWTYPE { get; set; }
        [Column("SWNAME")]
        [StringLength(100)]
        public string SWNAME { get; set; }
        [Column("SWVERSION")]
        [StringLength(50)]
        public string SWVERSION { get; set; }
        [Column("CUSRID")]
        [StringLength(16)]
        public string CUSRID { get; set; }
        [Column("CUSRPASS")]
        [StringLength(16)]
        public string CUSRPASS { get; set; }
        [Column("TVRID")]
        [StringLength(16)]
        public string TVRID { get; set; }
        [Column("TVRPASS")]
        [StringLength(16)]
        public string TVRPASS { get; set; }
        [Column("IPADD")]
        [StringLength(16)]
        public string IPADD { get; set; }
        [Column("SUBNET")]
        [StringLength(16)]
        public string SUBNET { get; set; }
        [Column("DGATEWAY")]
        [StringLength(16)]
        public string DGATEWAY { get; set; }
        [Column("PDNS")]
        [StringLength(16)]
        public string PDNS { get; set; }
        [Column("SDNS")]
        [StringLength(16)]
        public string SDNS { get; set; }
        [Column("OPTION1")]
        [StringLength(50)]
        public string OPTION1 { get; set; }
        [Column("OPTION2")]
        [StringLength(50)]
        public string OPTION2 { get; set; }
        [Column("OPTION3")]
        [StringLength(50)]
        public string OPTION3 { get; set; }
        [Column("OPTION4")]
        [StringLength(50)]
        public string OPTION4 { get; set; }
        [Column("OPTION5")]
        [StringLength(50)]
        public string OPTION5 { get; set; }
        [Column("CDATE")]
        public DateTime? CDATE { get; set; }
        [Column("UDATE")]
        public DateTime? UDATE { get; set; }
        [Column("STATUS")]
        [StringLength(12)]
        public string STATUS { get; set; }
        [Column("UPSTATUS")]
        [StringLength(12)]
        public string UPSTATUS { get; set; }
        [Column("DNSTATUS")]
        [StringLength(12)]
        public string DNSTATUS { get; set; }
        [Column("USRID")]
        [StringLength(16)]
        public string USRID { get; set; }
        [Column("BID")]
        [StringLength(16)]
        public string BID { get; set; }
    }
}
