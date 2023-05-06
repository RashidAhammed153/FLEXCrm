using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FLEXCrm.ViewModel
{
    public class ClientAndGroupVM
    {
        [Column("CRCID")]
        [StringLength(6)]
        public string CRCID { get; set; }
        [Column("CRCNAME")]
        [StringLength(75)]
        public string CRCNAME { get; set; }
        [Column("CRPREFIX")]
        [StringLength(4)]
        public string CRPREFIX { get; set; }
        [Column("CRGID")]
        [StringLength(2)]
        public string CRGID { get; set; }
        [Column("STREET")]
        [StringLength(150)]
        public string STREET { get; set; }
        [Column("CITY")]
        [StringLength(50)]
        public string CITY { get; set; }
        [Column("REGION")]
        [StringLength(50)]
        public string REGION { get; set; }
        [Column("STATE")]
        [StringLength(6)]
        public string STATE { get; set; }
        [Column("COUNTRY")]
        [StringLength(30)]
        public string COUNTRY { get; set; }
        [Column("CNAME")]
        [StringLength(50)]
        public string CNAME { get; set; }
        [Column("DESIGNATION")]
        [StringLength(50)]
        public string DESIGNATION { get; set; }
        [Column("PHONE")]
        [StringLength(50)]
        public string PHONE { get; set; }
        [Column("FAX")]
        [StringLength(50)]
        public string FAX { get; set; }
        [Column("MOBILE")]
        [StringLength(75)]
        public string MOBILE { get; set; }
        [Column("EMAIL")]
        [StringLength(75)]
        public string EMAIL { get; set; }
        [Column("EMAILII")]
        [StringLength(75)]
        public string EMAILII { get; set; }
        [Column("WEB")]
        [StringLength(75)]
        public string WEB { get; set; }
        [Column("PADDRESS")]
        [StringLength(250)]
        public string PADDRESS { get; set; }
        [Column("GRADE")]
        [StringLength(8)]
        public string GRADE { get; set; }
        [Column("ABOUT")]
        [StringLength(2550)]
        public string ABOUT { get; set; }
        [Column("NOTES")]
        [StringLength(5000)]
        public string NOTES { get; set; }
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
        [Column("CLOGO", TypeName = "image")]
        public byte[] CLOGO { get; set; }
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
        [Column("CRGNAME")]
        [StringLength(50)]
        public string CRGNAME { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(255)]
        public string DESCRIPTION { get; set; }
        [Column("CTID")]
        [StringLength(8)]
        public string CTID { get; set; }
        [Column("CTNAME")]
        [StringLength(250)]
        public string CTNAME { get; set; }
        [Column("CNID")]
        [StringLength(4)]
        public string CNID { get; set; }
        [Column("CODE")]
        [StringLength(6)]
        public string CODE { get; set; }
        [Column("ALIASS")]
        [StringLength(2)]
        public string ALIASS { get; set; }
        [Column("CALIAS")]
        [StringLength(50)]
        public string CALIAS { get; set; }
        [Column("DIVID")]
        [StringLength(2)]
        public string DIVID { get; set; }
        [Column("DIVNAME")]
        [StringLength(50)]
        public string DIVNAME { get; set; }

        [Column("DIVNAMEB")]
        [StringLength(50)]
        public string DIVNAMEB { get; set; }
        [Column("ISOCODE")]
        [StringLength(255)]
        public string ISOCODE { get; set; }
        [Column("ESTABLISH")]
        public int ESTABLISH { get; set; }
        [Column("DISTRICTS")]
        public int DISTRICTS { get; set; }
        [Column("UPZILAS")]
        public int UPZILAS { get; set; }
        [Column("UNIONCOUNCILS")]
        public int UNIONCOUNCILS { get; set; }
    }
}

