using System;
using System.Collections.Generic;
using FLEXCrm.DEMODATA;
using FLEXCrm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FLEXCrm.Data
{
    public partial class FLEXBDContext : DbContext
    {
        public FLEXBDContext()
        {
        }

        public FLEXBDContext(DbContextOptions<FLEXBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TBLACAP> TBLACAPs { get; set; } = null!;
        public virtual DbSet<TBLACAVREF> TBLACAVREFs { get; set; } = null!;
        public virtual DbSet<TBLACBALANCESHEET> TBLACBALANCESHEETs { get; set; } = null!;
        public virtual DbSet<TBLACBILLQUE> TBLACBILLQUEs { get; set; } = null!;
        public virtual DbSet<TBLACBRECONCILIATION> TBLACBRECONCILIATIONs { get; set; } = null!;
        public virtual DbSet<TBLACCCATEGORY> TBLACCCATEGORies { get; set; } = null!;
        public virtual DbSet<TBLACCCENTER> TBLACCCENTERs { get; set; } = null!;
        public virtual DbSet<TBLACCL> TBLACCLs { get; set; } = null!;
        public virtual DbSet<TBLACCLASS> TBLACCLASSes { get; set; } = null!;
        public virtual DbSet<TBLACDATE> TBLACDATEs { get; set; } = null!;
        public virtual DbSet<TBLACDEPRICIATIONINFO> TBLACDEPRICIATIONINFOs { get; set; } = null!;
        public virtual DbSet<TBLACELEDGER> TBLACELEDGERs { get; set; } = null!;
        public virtual DbSet<TBLACEXPENDITURESTATEMENT> TBLACEXPENDITURESTATEMENTs { get; set; } = null!;
        public virtual DbSet<TBLACGLEDGER> TBLACGLEDGERs { get; set; } = null!;
        public virtual DbSet<TBLACGLEDGERCC> TBLACGLEDGERCCs { get; set; } = null!;
        public virtual DbSet<TBLACGROUP> TBLACGROUPs { get; set; } = null!;
        public virtual DbSet<TBLACHEAD> TBLACHEADs { get; set; } = null!;
        public virtual DbSet<TBLACILEDGER> TBLACILEDGERs { get; set; } = null!;
        public virtual DbSet<TBLACINCOMESTATEMENT> TBLACINCOMESTATEMENTs { get; set; } = null!;
        public virtual DbSet<TBLACJOURNALDETAIL> TBLACJOURNALDETAILs { get; set; } = null!;
        public virtual DbSet<TBLACJOURNALMASTER> TBLACJOURNALMASTERs { get; set; } = null!;
        public virtual DbSet<TBLACJOURNALNOTE> TBLACJOURNALNOTEs { get; set; } = null!;
        public virtual DbSet<TBLACJOURNALSETTING> TBLACJOURNALSETTINGs { get; set; } = null!;
        public virtual DbSet<TBLACMONTHLY> TBLACMONTHLies { get; set; } = null!;
        public virtual DbSet<TBLACSLEDGER> TBLACSLEDGERs { get; set; } = null!;
        public virtual DbSet<TBLACSSLEDGER> TBLACSSLEDGERs { get; set; } = null!;
        public virtual DbSet<TBLACTLEDGER> TBLACTLEDGERs { get; set; } = null!;
        public virtual DbSet<TBLACTMPCR> TBLACTMPCRs { get; set; } = null!;
        public virtual DbSet<TBLACTMPDR> TBLACTMPDRs { get; set; } = null!;
        public virtual DbSet<TBLACTRIALBALANCE> TBLACTRIALBALANCEs { get; set; } = null!;
        public virtual DbSet<TBLACVOUCHER> TBLACVOUCHERs { get; set; } = null!;
        public virtual DbSet<TBLACYCB> TBLACYCBs { get; set; } = null!;
        public virtual DbSet<TBLADVANCEANALYSI> TBLADVANCEANALYses { get; set; } = null!;
        public virtual DbSet<TBLAGENTDB> TBLAGENTDBs { get; set; } = null!;
        public virtual DbSet<TBLAGENTINFO> TBLAGENTINFOs { get; set; } = null!;
        public virtual DbSet<TBLAGENTTYPE> TBLAGENTTYPEs { get; set; } = null!;
        public virtual DbSet<TBLBACKUPLOG> TBLBACKUPLOGs { get; set; } = null!;
        public virtual DbSet<TBLCHARGESETTING> TBLCHARGESETTINGs { get; set; } = null!;
        public virtual DbSet<TBLCITY> TBLCITY { get; set; } = null!;
        public virtual DbSet<TBLCOMINFO> TBLCOMINFOs { get; set; } = null!;
        public virtual DbSet<TBLCOUNTRY> TBLCOUNTRY { get; set; } = null!;
        public virtual DbSet<TBLCREGROUP> TBLCREGROUPs { get; set; } = null!;
        public virtual DbSet<TBLCRMCLIENT> TBLCRMCLIENT { get; set; } = null!;
        public virtual DbSet<TBLCRMGROUP> TBLCRMGROUP { get; set; } = null!;
        public virtual DbSet<TBLCRMREGION> TBLCRMREGIONs { get; set; } = null!;
        public virtual DbSet<TBLCRMTEAM> TBLCRMTEAMs { get; set; } = null!;
        public virtual DbSet<TBLCRMTECHAMC> TBLCRMTECHAMC { get; set; } = null!;
        public virtual DbSet<TBLCRMTECHDETAIL> TBLCRMTECHDETAILs { get; set; } = null!;
        public virtual DbSet<TBLCRMTECHMASTER> TBLCRMTECHMASTER { get; set; } = null!;
        public virtual DbSet<TBLDASHBOARD> TBLDASHBOARDs { get; set; } = null!;
        public virtual DbSet<TBLDASHBOARDDETAIL> TBLDASHBOARDDETAILs { get; set; } = null!;
        public virtual DbSet<TBLDEPARTMENT> TBLDEPARTMENTs { get; set; } = null!;
        public virtual DbSet<TBLDIVISION> TBLDIVISION { get; set; } = null!;
        public virtual DbSet<TBLEMAILMASTER> TBLEMAILMASTERs { get; set; } = null!;
        public virtual DbSet<TBLEMAILSEND> TBLEMAILSENDs { get; set; } = null!;
        public virtual DbSet<TBLEMAILSETTING> TBLEMAILSETTINGs { get; set; } = null!;
        public virtual DbSet<TBLERRORLOG> TBLERRORLOGs { get; set; } = null!;
        public virtual DbSet<TBLEVNDETAIL> TBLEVNDETAILs { get; set; } = null!;
        public virtual DbSet<TBLEVNDETAILSTMP> TBLEVNDETAILSTMPs { get; set; } = null!;
        public virtual DbSet<TBLEVNMASTER> TBLEVNMASTERs { get; set; } = null!;
        public virtual DbSet<TBLEVNNOTE> TBLEVNNOTEs { get; set; } = null!;
        public virtual DbSet<TBLEVNTIME> TBLEVNTIMEs { get; set; } = null!;
        public virtual DbSet<TBLEXPORTLOG> TBLEXPORTLOGs { get; set; } = null!;
        public virtual DbSet<TBLEXPORTTALLYSETTING> TBLEXPORTTALLYSETTINGs { get; set; } = null!;
        public virtual DbSet<TBLFXRATE> TBLFXRATEs { get; set; } = null!;
        public virtual DbSet<TBLFYEAR> TBLFYEARs { get; set; } = null!;
        public virtual DbSet<TBLHOTSOPTUSER> TBLHOTSOPTUSERs { get; set; } = null!;
        public virtual DbSet<TBLHOTSPOTDEVICE> TBLHOTSPOTDEVICEs { get; set; } = null!;
        public virtual DbSet<TBLHOTSPOTSETTING> TBLHOTSPOTSETTINGs { get; set; } = null!;
        public virtual DbSet<TBLHOTSPOTUSE> TBLHOTSPOTUSEs { get; set; } = null!;
        public virtual DbSet<TBLHRAPPOINTMENTLETTER> TBLHRAPPOINTMENTLETTERs { get; set; } = null!;
        public virtual DbSet<TBLHRATTENDANCE> TBLHRATTENDANCEs { get; set; } = null!;
        public virtual DbSet<TBLHRATTENDANCESM> TBLHRATTENDANCESMs { get; set; } = null!;
        public virtual DbSet<TBLHRDEPARTMENT> TBLHRDEPARTMENTs { get; set; } = null!;
        public virtual DbSet<TBLHRDESIGNATION> TBLHRDESIGNATIONs { get; set; } = null!;
        public virtual DbSet<TBLHRDIVISION> TBLHRDIVISIONs { get; set; } = null!;
        public virtual DbSet<TBLHREMPLOYEE> TBLHREMPLOYEEs { get; set; } = null!;
        public virtual DbSet<TBLHREMPLOYEEEDU> TBLHREMPLOYEEEDUs { get; set; } = null!;
        public virtual DbSet<TBLHRHOLIDAYTYPE> TBLHRHOLIDAYTYPEs { get; set; } = null!;
        public virtual DbSet<TBLHRLEAVE> TBLHRLEAVEs { get; set; } = null!;
        public virtual DbSet<TBLHRLEAVEDETAIL> TBLHRLEAVEDETAILs { get; set; } = null!;
        public virtual DbSet<TBLHRLEAVEREQUEST> TBLHRLEAVEREQUESTs { get; set; } = null!;
        public virtual DbSet<TBLHRLEAVEREQUESTDETAIL> TBLHRLEAVEREQUESTDETAILs { get; set; } = null!;
        public virtual DbSet<TBLHRLEAVEREQUESTDETAILSTMP> TBLHRLEAVEREQUESTDETAILSTMPs { get; set; } = null!;
        public virtual DbSet<TBLHRLEAVESM> TBLHRLEAVESMs { get; set; } = null!;
        public virtual DbSet<TBLHRLEAVETYPE> TBLHRLEAVETYPEs { get; set; } = null!;
        public virtual DbSet<TBLHRSCHARGE> TBLHRSCHARGEs { get; set; } = null!;
        public virtual DbSet<TBLHRSECTION> TBLHRSECTIONs { get; set; } = null!;
        public virtual DbSet<TBLHRSHIFT> TBLHRSHIFTs { get; set; } = null!;
        public virtual DbSet<TBLHRSSALARY> TBLHRSSALARies { get; set; } = null!;
        public virtual DbSet<TBLHRSSETUP> TBLHRSSETUPs { get; set; } = null!;
        public virtual DbSet<TBLHRTD> TBLHRTDs { get; set; } = null!;
        public virtual DbSet<TBLHRTERM> TBLHRTERMs { get; set; } = null!;
        public virtual DbSet<TBLINITIAL> TBLINITIALs { get; set; } = null!;
        public virtual DbSet<TBLSECTION> TBLSECTIONs { get; set; } = null!;
        public virtual DbSet<TBLSERVICE> TBLSERVICEs { get; set; } = null!;
        public virtual DbSet<TBLSYNCDETAIL> TBLSYNCDETAILs { get; set; } = null!;
        public virtual DbSet<TBLSYNCLOGDETAIL> TBLSYNCLOGDETAILs { get; set; } = null!;
        public virtual DbSet<TBLSYNCMASTER> TBLSYNCMASTERs { get; set; } = null!;
        public virtual DbSet<TBLSYNCSETTING> TBLSYNCSETTINGs { get; set; } = null!;
        public virtual DbSet<TBLTMIMAGE> TBLTMIMAGEs { get; set; } = null!;
        public virtual DbSet<TBLUDEFINE> TBLUDEFINEs { get; set; } = null!;
        public virtual DbSet<TBLUSERACCESSLOG> TBLUSERACCESSLOGs { get; set; } = null!;
        public virtual DbSet<TBLUSERGROUP> TBLUSERGROUPs { get; set; } = null!;
        public virtual DbSet<TBLUSERGROUPPRIVELEGE> TBLUSERGROUPPRIVELEGEs { get; set; } = null!;
        public virtual DbSet<TBLUSERGROUPPRIVELEGETMP> TBLUSERGROUPPRIVELEGETMPs { get; set; } = null!;
        public virtual DbSet<TBLUSERINFO> TBLUSERINFOs { get; set; } = null!;
        public virtual DbSet<TBLUSERREPORT> TBLUSERREPORTs { get; set; } = null!;
        public virtual DbSet<TBLZONE> TBLZONEs { get; set; } = null!;
        public virtual DbSet<UserInfo> UserInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=appsdb.flexinfosys.com;Database=FLEXBD;User Id=sa;Password=FLEX@bd8691#");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLACAP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACAP");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ACHID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FYEAR)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACAVREF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACAVREF");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REFNO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.REFSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACBALANCESHEET>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACBALANCESHEET");

                entity.Property(e => e.ACBTYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ACCID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ACHID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FYEAR)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STSTUS)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACBILLQUE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACBILLQUE");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CDPTNO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSTID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NARRATION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RFROM)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACBRECONCILIATION>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACBRECONCILIATION");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BDATE).HasColumnType("date");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EDATE).HasColumnType("date");

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDL)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.STS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACCCATEGORY>(entity =>
            {
                entity.HasKey(e => new { e.ACCTID, e.ACGID });

                entity.ToTable("TBLACCCATEGORY");

                entity.Property(e => e.ACCTID)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ACGID)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ACCTNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACCCENTER>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACCCENTER");

                entity.Property(e => e.ACCNID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ACCTID)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACCL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACCL");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ACHID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FYEAR)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACCLASS>(entity =>
            {
                entity.HasKey(e => e.ACCID)
                    .HasName("IX_TBLACCLASS_ACCID");

                entity.ToTable("TBLACCLASS");

                entity.HasIndex(e => e.ACGID, "IX_TBLACCLASS_ACGID");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ACGID)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACDATE>(entity =>
            {
                entity.HasKey(e => e.SYSDT);

                entity.ToTable("TBLACDATE");

                entity.Property(e => e.SYSDT).HasColumnType("datetime");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TDID).ValueGeneratedOnAdd();

                entity.Property(e => e.TRNDT).HasColumnType("datetime");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACDEPRICIATIONINFO>(entity =>
            {
                entity.HasKey(e => e.DID)
                    .HasName("PK_TBLDEPRICIATIONINFO");

                entity.ToTable("TBLACDEPRICIATIONINFO");

                entity.Property(e => e.DID).ValueGeneratedNever();

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ACHID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DDATED).HasColumnType("datetime");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DMETHOD)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACELEDGER>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACELEDGER");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACEXPENDITURESTATEMENT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACEXPENDITURESTATEMENT");

                entity.Property(e => e.ACHID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACGLEDGER>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACGLEDGER");

                entity.HasIndex(e => e.ACCID, "IX_TBLACGLEDGER_ACCID");

                entity.HasIndex(e => e.ACCNAME, "IX_TBLACGLEDGER_ACCNAME");

                entity.HasIndex(e => e.VTYPE, "IX_TBLACGLEDGER_VTYPE");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACGLEDGERCC>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACGLEDGERCC");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACGROUP>(entity =>
            {
                entity.HasKey(e => e.ACGID);

                entity.ToTable("TBLACGROUP");

                entity.Property(e => e.ACGID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACGNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ACGTYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACHEAD>(entity =>
            {
                entity.HasKey(e => e.ACHID)
                    .HasName("IX_TBLACHEAD_ACHID");

                entity.ToTable("TBLACHEAD");

                entity.HasIndex(e => e.ACCID, "IX_TBLACHEAD_ACCID");

                entity.Property(e => e.ACHID)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ACCID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACILEDGER>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACILEDGER");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACINCOMESTATEMENT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACINCOMESTATEMENT");

                entity.Property(e => e.ACHID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACJOURNALDETAIL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACJOURNALDETAILS");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CDPTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSTID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NARRATION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACJOURNALMASTER>(entity =>
            {
                entity.HasKey(e => e.TRNID)
                    .HasName("PK_TBLJOURNALMASTER");

                entity.ToTable("TBLACJOURNALMASTER");

                entity.Property(e => e.TRNID).ValueGeneratedNever();

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACJOURNALNOTE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACJOURNALNOTES");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CDPTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSTID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JNDATE).HasColumnType("datetime");

                entity.Property(e => e.JNID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.JNOPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JNOPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JNOPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JNOPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JNOPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NARRATION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACJOURNALSETTING>(entity =>
            {
                entity.HasKey(e => e.TRNID);

                entity.ToTable("TBLACJOURNALSETTINGS");

                entity.Property(e => e.TRNID).ValueGeneratedNever();

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACMONTHLY>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACMONTHLY");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PARTICULARS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACSLEDGER>(entity =>
            {
                entity.HasKey(e => e.ACSLID)
                    .HasName("IX_TBLSLEDGER_ACSLID");

                entity.ToTable("TBLACSLEDGER");

                entity.HasIndex(e => e.ACHID, "IX_TBLSLEDGER_ACHID");

                entity.Property(e => e.ACSLID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACHID)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACSSLEDGER>(entity =>
            {
                entity.HasKey(e => e.ACSSLID)
                    .HasName("IX_TBLSSLEDGER_ACSSLID");

                entity.ToTable("TBLACSSLEDGER");

                entity.HasIndex(e => e.ACSLID, "IX_TBLACSSLEDGER_ACSLID");

                entity.Property(e => e.ACSSLID)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACSSLNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACTLEDGER>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACTLEDGER");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRANDATE).HasColumnType("datetime");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACTMPCR>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACTMPCR");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CDPTNO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSTID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NARRATION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACTMPDR>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACTMPDR");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CDPTNO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CHQ)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSTID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NARRATION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACTRIALBALANCE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACTRIALBALANCE");

                entity.Property(e => e.ACHID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACSLNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACVOUCHER>(entity =>
            {
                entity.HasKey(e => e.VID)
                    .HasName("PK_TBLACVOUCHER_VID");

                entity.ToTable("TBLACVOUCHER");

                entity.HasIndex(e => e.DESCRIPTION, "IX_TBLACVOUCHER_TYPE");

                entity.Property(e => e.VID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLACYCB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLACYCB");

                entity.HasIndex(e => e.ACCID, "IX_TBLACYCB_ACCID");

                entity.HasIndex(e => e.ACHID, "IX_TBLACYCB_ACHID");

                entity.Property(e => e.ACCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ACCNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ACHID)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ACHNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AL)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FYEAR)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SHOW)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLADVANCEANALYSI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLADVANCEANALYSIS");

                entity.Property(e => e.BID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CM1DATE).HasColumnType("datetime");

                entity.Property(e => e.CM1REF)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CM2DATE).HasColumnType("datetime");

                entity.Property(e => e.CM2REF)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CM3DATE).HasColumnType("datetime");

                entity.Property(e => e.CM3REF)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CM4DATE).HasColumnType("datetime");

                entity.Property(e => e.CM4REF)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CM5DATE).HasColumnType("datetime");

                entity.Property(e => e.CM5REF)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DATED).HasColumnType("datetime");

                entity.Property(e => e.ITEMID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LDATE).HasColumnType("datetime");

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION10)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION7)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION8)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION9)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLAGENTDB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLAGENTDB");

                entity.Property(e => e.AIID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DBNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DBPASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DBPFIX)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DBUSER)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEDB)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEPASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEUSR)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLAGENTINFO>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLAGENTINFO");

                entity.Property(e => e.ABOUTAGENT)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.AIID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AINAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ATID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CITY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTY)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DBNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DBPASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DBPFIX)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DBUSER)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MOBILE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEDB)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEPASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEUSR)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REGION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STREET)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.WEB)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLAGENTTYPE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLAGENTTYPE");

                entity.Property(e => e.ATID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ATNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLBACKUPLOG>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLBACKUPLOG");

                entity.Property(e => e.BACKUPLOCATION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BDATE).HasColumnType("datetime");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCHARGESETTING>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLCHARGESETTINGS");

                entity.Property(e => e.BID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EDATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<TBLCITY>(entity =>
            {
                entity.HasKey(e => e.CTID);

                entity.ToTable("TBLCITY");

                entity.Property(e => e.CTID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ALIASS)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CNID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CODE)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CTNAME)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCOMINFO>(entity =>
            {
                entity.HasKey(e => e.COMID);

                entity.ToTable("TBLCOMINFO");

                entity.Property(e => e.COMID).ValueGeneratedNever();

                entity.Property(e => e.ACCESSLOG)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ALTERNETCURRENCY)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AUTOPRINT)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BACKUPLOOCATION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BACKUPLOOCATIONII)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BSRVNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CITY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CLLEDGER).HasColumnType("datetime");

                entity.Property(e => e.COMADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.COMNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COMPREFIX)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.COMPTYPE)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CTYP)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DBNAME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DEMOORG)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EXPDATE).HasColumnType("datetime");

                entity.Property(e => e.FAX)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FROMDATA)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FYEND).HasColumnType("datetime");

                entity.Property(e => e.FYSTART).HasColumnType("datetime");

                entity.Property(e => e.INSDATE).HasColumnType("datetime");

                entity.Property(e => e.LOGO).HasColumnType("image");

                entity.Property(e => e.LSTDATE).HasColumnType("datetime");

                entity.Property(e => e.MSRVNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OFFICEBRANCE)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ONDATABASE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ONPASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ONPORT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ONSERVER)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ONUSR)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION9)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYMENTGETWAY)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PAYMENTLINK)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PCODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.POFFICE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.POWEREDBY)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PRIMARYCURRENCY)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.REVERSER)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STLDATE).HasColumnType("datetime");

                entity.Property(e => e.STYLE)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SYSTEMAUTHORIZATION)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TITLE)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TODATA)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USERLOG)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCOUNTRY>(entity =>
            {
                entity.HasKey(e => e.CNID);

                entity.ToTable("TBLCOUNTRY");

                entity.Property(e => e.CNID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CALIAS)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CNNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCREGROUP>(entity =>
            {
                entity.HasKey(e => e.CREID);

                entity.ToTable("TBLCREGROUP");

                entity.Property(e => e.CREID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CRENAME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCRMCLIENT>(entity =>
            {
                entity.HasKey(e => e.CRCID);

                entity.ToTable("TBLCRMCLIENT");

                entity.Property(e => e.CRCID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ABOUT)
                    .HasMaxLength(2550)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CDATE).HasColumnType("date");

                entity.Property(e => e.CITY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CLOGO).HasColumnType("image");

                entity.Property(e => e.CNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CRCNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CRGID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CRPREFIX)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DESIGNATION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.EMAILII)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FAX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GRADE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MOBILE)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REGION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATE)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STREET)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UDATE).HasColumnType("date");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.WEB)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCRMGROUP>(entity =>
            {
                entity.HasKey(e => e.CRGID);

                entity.ToTable("TBLCRMGROUP");

                entity.Property(e => e.CRGID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CRGNAME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCRMREGION>(entity =>
            {
                entity.HasKey(e => e.DIID);

                entity.ToTable("TBLCRMREGION");

                entity.Property(e => e.DIID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ABOUTDESTINATION)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CITY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DINAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DISTANCE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ELEVATION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GLID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LOCATION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCRMTEAM>(entity =>
            {
                entity.HasKey(e => e.EMPID);

                entity.ToTable("TBLCRMTEAM");

                entity.Property(e => e.EMPID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BDATE).HasColumnType("datetime");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CUSRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DEPARTMENT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESIGNATION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMPNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FAX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GRPID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.JDATE).HasColumnType("datetime");

                entity.Property(e => e.MOBILE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPT1)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.OPT2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPT3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPT4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPT5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PHINT)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHOTO).HasColumnType("image");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UTYP)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCRMTECHAMC>(entity =>
            {
                entity.HasKey(e => e.TAID);

                entity.ToTable("TBLCRMTECHAMC");

                entity.Property(e => e.TAID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AUPDATE).HasColumnType("date");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CDATE).HasColumnType("date");

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EDATE).HasColumnType("date");

                entity.Property(e => e.NLICENCE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OLICENCE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OLSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PTYPE)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RDATE).HasColumnType("date");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SWVERSION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TMID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UDATE).HasColumnType("date");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCRMTECHDETAIL>(entity =>
            {
                entity.HasKey(e => e.TDID);

                entity.ToTable("TBLCRMTECHDETAILS");

                entity.Property(e => e.TDID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CDATE).HasColumnType("date");

                entity.Property(e => e.CUSRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CUSRPASS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DGATEWAY)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IPADD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PDNS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SDNS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SUBNET)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SWNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SWTYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SWVERSION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TMID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TVRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TVRPASS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UDATE).HasColumnType("date");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLCRMTECHMASTER>(entity =>
            {
                entity.HasKey(e => e.TMID);

                entity.ToTable("TBLCRMTECHMASTER");

                entity.Property(e => e.TMID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BACKUPLOOCATION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BACKUPLOOCATIONII)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.COMADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.COMNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COMPREFIX)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CRCID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DBNAME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DEMOORG)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EXPDATE).HasColumnType("datetime");

                entity.Property(e => e.INSDATE).HasColumnType("datetime");

                entity.Property(e => e.LICENCENO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LSTDATE).HasColumnType("datetime");

                entity.Property(e => e.OFFICEBRANCE)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION10)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION9)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PTYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RRCOLOOCATION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SMODULE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SVERSION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TITLE)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLDASHBOARD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLDASHBOARD");

                entity.Property(e => e.BID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CLM01)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM02)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM03)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM04)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM05)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM06)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM07)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM08)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM09)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM15)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLDASHBOARDDETAIL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLDASHBOARDDETAILS");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CLM02).HasColumnType("datetime");

                entity.Property(e => e.CLM03)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM04)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM05)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM21)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM22)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM23)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM24)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLM25)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLDEPARTMENT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLDEPARTMENT");

                entity.Property(e => e.DEPID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DEPNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DIVID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PMETHOD)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLDIVISION>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLDIVISION");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DIVID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DIVNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIVNAMEB)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ISOCODE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEMAILMASTER>(entity =>
            {
                entity.HasKey(e => new { e.ESETNAME, e.ESETDETAILS });

                entity.ToTable("TBLEMAILMASTER");

                entity.Property(e => e.ESETNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ESETDETAILS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CREATEDATE).HasColumnType("datetime");

                entity.Property(e => e.DISCLAIMER)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MAILBODY)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.MAILBY)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MAILFOOTER)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MAILFROM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAILHEADER)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MAILMENTION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAILNOTES)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.MAILPASS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAILSUB)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MSGFORMAT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MSGPRIORITY)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MSGSCHEUDLETIME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MSGTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OUTGOINGMAILSERVER)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PORTNO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SENDBCC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SENDCC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SENDCRITERIA)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SENDDATETIME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SENDFROM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SENDTO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL1)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL10)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL2)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL3)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL4)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL5)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL6)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL7)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL8)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SOCIAL9)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPDATEDATE).HasColumnType("datetime");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEMAILSEND>(entity =>
            {
                entity.HasKey(e => e.SRNO);

                entity.ToTable("TBLEMAILSEND");

                entity.Property(e => e.SRNO).ValueGeneratedNever();

                entity.Property(e => e.ATTACHMENT).IsUnicode(false);

                entity.Property(e => e.ATTACHMENT2).IsUnicode(false);

                entity.Property(e => e.ATTACHMENT3).IsUnicode(false);

                entity.Property(e => e.ATTACHMENT4).IsUnicode(false);

                entity.Property(e => e.ATTACHMENT5).IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MSGFORMAT)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MSGPRIORITY)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MSGTYPE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REFNO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SCHDULED)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SNDBCC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SNDBY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNDCC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SNDCRITERIA)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SNDDATED).HasColumnType("datetime");

                entity.Property(e => e.SNDFROM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNDMESSAGE).IsUnicode(false);

                entity.Property(e => e.SNDSUBJECT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNDTO)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SNDTYPE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEMAILSETTING>(entity =>
            {
                entity.HasKey(e => e.ESETNAME);

                entity.ToTable("TBLEMAILSETTINGS");

                entity.Property(e => e.ESETNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DEFAULTID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DISPLAYNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ESETDETAILS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MAILFROM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAILPASS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAILTO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MSGFORMAT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MSGNOTES)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MSGPRIORITY)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MSGSCHEUDLETIME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MSGTYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OUTGOINGMAILSERVER)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PORTNO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SENDBY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SENDCRITERIA)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SENDDATETIME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SENDFROM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLERRORLOG>(entity =>
            {
                entity.HasKey(e => e.ERRID);

                entity.ToTable("TBLERRORLOG");

                entity.Property(e => e.ERRID).ValueGeneratedNever();

                entity.Property(e => e.BID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CHECKIN).HasColumnType("datetime");

                entity.Property(e => e.CHECKOUT).HasColumnType("datetime");

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ERROR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GSID)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IGROUP)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MINV)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OCIDATE).HasColumnType("datetime");

                entity.Property(e => e.OCODATE).HasColumnType("datetime");

                entity.Property(e => e.OGROUP)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OGSID)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEVNDETAIL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLEVNDETAILS");

                entity.Property(e => e.EINV)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ITEMID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ITEMNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ITEMSRNO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RQTY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDATE).HasColumnType("datetime");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEVNDETAILSTMP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLEVNDETAILSTMP");

                entity.Property(e => e.EINV)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ITEMID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ITEMNAME)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ITEMSRNO)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MRQTY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QCQTY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDATE).HasColumnType("datetime");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEVNMASTER>(entity =>
            {
                entity.HasKey(e => e.EINV)
                    .HasName("PK_TBLENVMASTER");

                entity.ToTable("TBLEVNMASTER");

                entity.Property(e => e.EINV)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BDATE).HasColumnType("datetime");

                entity.Property(e => e.BID)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BILLINSTRUCTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BILLMODE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BILLTYPE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BOOKEDBY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DRNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ELOCATION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ENAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ETYPE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FDATE).HasColumnType("datetime");

                entity.Property(e => e.FTIME)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GSID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ISBILL)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.JVNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PRIORITY)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.REFNO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RRCOEXP)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SALOC)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SPERSON)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SREQUIREMENT)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.TDATE).HasColumnType("datetime");

                entity.Property(e => e.TEXPORT)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TTIME)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEVNNOTE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLEVNNOTES");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BILLAPPLICABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DATED).HasColumnType("datetime");

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EINV)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EVENTNOTES)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RNSTATUS)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEVNTIME>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLEVNTIME");

                entity.Property(e => e.BID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ETID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ETIME)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ETSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEXPORTLOG>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLEXPORTLOG");

                entity.Property(e => e.BACKUPLOCATION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DATED).HasColumnType("datetime");

                entity.Property(e => e.EXDATE).HasColumnType("datetime");

                entity.Property(e => e.EXUDATE).HasColumnType("datetime");

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLEXPORTTALLYSETTING>(entity =>
            {
                entity.HasKey(e => new { e.TSID, e.DRCR });

                entity.ToTable("TBLEXPORTTALLYSETTINGS");

                entity.Property(e => e.DRCR)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FLXNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TALLYNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.TSCATEGORY)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLFXRATE>(entity =>
            {
                entity.HasKey(e => e.DATED)
                    .HasName("PK_TBLFXRATE_1");

                entity.ToTable("TBLFXRATE");

                entity.Property(e => e.DATED).HasColumnType("datetime");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CREATEDATE).HasColumnType("datetime");

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SOURCES)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLFYEAR>(entity =>
            {
                entity.HasKey(e => e.FYear);

                entity.ToTable("TBLFYEAR");

                entity.HasIndex(e => e.FYear, "IX_TBLFYEAR_FYEAR");

                entity.Property(e => e.FYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EMonth)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SMonth)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHOTSOPTUSER>(entity =>
            {
                entity.HasKey(e => e.IDNO);

                entity.ToTable("TBLHOTSOPTUSER");

                entity.Property(e => e.IDNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ADDEVICE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CRDATE).HasColumnType("datetime");

                entity.Property(e => e.DEPARTMENT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESIGNATION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRCODE)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHOTSPOTDEVICE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHOTSPOTDEVICES");

                entity.Property(e => e.BLUETOOTHADDRESS)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DEVICEDESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DEVICEINFO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DEVICETYPE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ICCID)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IDNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IMEI)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MEID)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MODELNO)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SLN).ValueGeneratedOnAdd();

                entity.Property(e => e.SRNO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WIFIADDRESS)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHOTSPOTSETTING>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHOTSPOTSETTINGS");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GPDG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GPPV)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GPSMS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HOSTDATABASE)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HOSTNAME)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.HOSTPASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.HOSTPORT)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HOSTUSER)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.HOTSPOTTABLE)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PGANV)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PGLNG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PGRNV)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHOTSPOTUSE>(entity =>
            {
                entity.HasKey(e => e.SRNO);

                entity.ToTable("TBLHOTSPOTUSES");

                entity.Property(e => e.SRNO).ValueGeneratedNever();

                entity.Property(e => e.ALUSRID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CHECKIN).HasColumnType("datetime");

                entity.Property(e => e.CHECKOUT).HasColumnType("datetime");

                entity.Property(e => e.DEVICEINFO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DEVICETYPE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DURATION)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HSACCESS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HSGENERATION)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IDNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IPADDRESS)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MACAD)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PASSWORD)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PURPOSE)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.STARTTIME).HasColumnType("datetime");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRCODE)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.USRTYPE)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRAPPOINTMENTLETTER>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHRAPPOINTMENTLETTER");

                entity.Property(e => e.ADMREF)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CNDATE).HasColumnType("date");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SUSRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TRID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TRNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRATTENDANCE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHRATTENDANCE");

                entity.Property(e => e.BRCNAME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CTGNAME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DPTNAME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DSGNAME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FIRSTHALF)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GRDNAME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ORGNAME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PROCESSDATE)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH1)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH1_DATE)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH1_TIME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH2)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH2_DATE)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH2_TIME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH3)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH3_DATE)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PUNCH3_TIME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SCHEDULESHIFT)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SECNAME)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SECONDHALF)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.USERID)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.USERNAME)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TBLHRATTENDANCESM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHRATTENDANCESM");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DPNAME)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DSNAME)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MAID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDATED).HasColumnType("date");

                entity.Property(e => e.SMONTH)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SYEAR)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRDEPARTMENT>(entity =>
            {
                entity.HasKey(e => e.DPNAME);

                entity.ToTable("TBLHRDEPARTMENT");

                entity.Property(e => e.DPNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DPADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DPID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DVID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FAX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TELEPHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRDESIGNATION>(entity =>
            {
                entity.HasKey(e => e.DSNAME);

                entity.ToTable("TBLHRDESIGNATION");

                entity.Property(e => e.DSNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DSID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRDIVISION>(entity =>
            {
                entity.HasKey(e => e.DVNAME);

                entity.ToTable("TBLHRDIVISION");

                entity.Property(e => e.DVNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DVID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHREMPLOYEE>(entity =>
            {
                entity.HasKey(e => e.EID);

                entity.ToTable("TBLHREMPLOYEE");

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ATYPE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BGROUP)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DFEATURE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DOB).HasColumnType("datetime");

                entity.Property(e => e.DOJ).HasColumnType("datetime");

                entity.Property(e => e.DPHOTO).HasColumnType("image");

                entity.Property(e => e.DPID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DSID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EDUCATION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EFNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ENAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.EPHOTO).HasColumnType("image");

                entity.Property(e => e.ETYPE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EYECOLOR)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.GENDER)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HEIGHT)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MEDICALHISTORY)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MOBILE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NATIONALITY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOSPOUSE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PASSPORT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PERADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PERDZONGKHAG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PERGEOG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PERTHRAM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PERVILLAGE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPHOTO).HasColumnType("image");

                entity.Property(e => e.PREADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PREDZONGKHAG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PREGEOG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PREVILLAGE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELIGION)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SCID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SPOUSEADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.WEIGHT)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHREMPLOYEEEDU>(entity =>
            {
                entity.HasKey(e => e.EDID);

                entity.ToTable("TBLHREMPLOYEEEDU");

                entity.Property(e => e.EDID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DCNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DCPHOTO).HasColumnType("image");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ORIGINAL)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PHOTOCOPY)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRHOLIDAYTYPE>(entity =>
            {
                entity.HasKey(e => e.HTNAME);

                entity.ToTable("TBLHRHOLIDAYTYPE");

                entity.Property(e => e.HTNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HTID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRLEAVE>(entity =>
            {
                entity.HasKey(e => new { e.EID, e.YEAR });

                entity.ToTable("TBLHRLEAVE");

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YEAR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRLEAVEDETAIL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHRLEAVEDETAILS");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.D01)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D02)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D03)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D04)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D05)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D06)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D07)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D08)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D09)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D10)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D11)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D12)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D13)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D14)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D15)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D16)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D17)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D18)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D19)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D20)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D21)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D22)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D23)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D24)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D25)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D26)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D27)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D28)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D29)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D30)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D31)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DPNAME)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DSNAME)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MLID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDATED).HasColumnType("date");

                entity.Property(e => e.SMONTH)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SYEAR)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRLEAVEREQUEST>(entity =>
            {
                entity.HasKey(e => e.LRID);

                entity.ToTable("TBLHRLEAVEREQUEST");

                entity.Property(e => e.LRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AMND)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DHCOMMENTS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DHDATE).HasColumnType("datetime");

                entity.Property(e => e.DHEID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DHSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DORW).HasColumnType("datetime");

                entity.Property(e => e.EID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.GMCOMMENTS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GMDATE).HasColumnType("datetime");

                entity.Property(e => e.GMEID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.GMSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.HRCOMMENTS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HRDATE).HasColumnType("datetime");

                entity.Property(e => e.HREID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.HRSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.JSHIFT)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LTYPE)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LVFROM).HasColumnType("datetime");

                entity.Property(e => e.LVTO).HasColumnType("datetime");

                entity.Property(e => e.MCERTIFICATION)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RDATE).HasColumnType("datetime");

                entity.Property(e => e.REASON)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRLEAVEREQUESTDETAIL>(entity =>
            {
                entity.HasKey(e => new { e.LRID, e.SRNO });

                entity.ToTable("TBLHRLEAVEREQUESTDETAILS");

                entity.Property(e => e.LRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LTID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LVFROM).HasColumnType("datetime");

                entity.Property(e => e.LVTFROM).HasColumnType("datetime");

                entity.Property(e => e.LVTO).HasColumnType("datetime");

                entity.Property(e => e.LVTTO).HasColumnType("datetime");

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRLEAVEREQUESTDETAILSTMP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHRLEAVEREQUESTDETAILSTMP");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LTID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LVFROM).HasColumnType("datetime");

                entity.Property(e => e.LVTFROM).HasColumnType("datetime");

                entity.Property(e => e.LVTO).HasColumnType("datetime");

                entity.Property(e => e.LVTTO).HasColumnType("datetime");

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRLEAVESM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHRLEAVESM");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DPNAME)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DSNAME)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LSID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDATED).HasColumnType("date");

                entity.Property(e => e.SMONTH)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SYEAR)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRLEAVETYPE>(entity =>
            {
                entity.HasKey(e => e.LTNAME);

                entity.ToTable("TBLHRLEAVETYPE");

                entity.Property(e => e.LTNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LTID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRSCHARGE>(entity =>
            {
                entity.HasKey(e => new { e.EID, e.SMONTH, e.SYEAR });

                entity.ToTable("TBLHRSCHARGE");

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SMONTH)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SYEAR)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DPNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DSNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDATED).HasColumnType("date");

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRSECTION>(entity =>
            {
                entity.HasKey(e => e.SCNAME);

                entity.ToTable("TBLHRSECTION");

                entity.Property(e => e.SCNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DPID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRSHIFT>(entity =>
            {
                entity.HasKey(e => e.SFNAME);

                entity.ToTable("TBLHRSHIFT");

                entity.Property(e => e.SFNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CHECKIN)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CHECKOUT)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRSSALARY>(entity =>
            {
                entity.HasKey(e => new { e.EID, e.SMONTH, e.SYEAR });

                entity.ToTable("TBLHRSSALARY");

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SMONTH)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SYEAR)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CSTIDA)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DPNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DSNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GIAC)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OSAC)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PFAC)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SALIDA)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SALIDE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SALIDL)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SDATED).HasColumnType("date");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SVAC)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VNO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VTYPE)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRSSETUP>(entity =>
            {
                entity.HasKey(e => e.EID);

                entity.ToTable("TBLHRSSETUP");

                entity.Property(e => e.EID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CSTIDA)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GIAC)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OSAC)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PFAC)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SALIDA)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SALIDE)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SALIDL)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SVAC)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRTD>(entity =>
            {
                entity.HasKey(e => e.SRNO);

                entity.ToTable("TBLHRTDS");

                entity.Property(e => e.SRNO).ValueGeneratedNever();

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EDATE).HasColumnType("date");

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLHRTERM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLHRTERMS");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION5)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TRID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TRNAME)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLINITIAL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLINITIALS");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CONDITION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CONDITION2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.INIID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ININAME)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLSECTION>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLSECTION");

                entity.Property(e => e.DEPID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SECID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SECNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLSERVICE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLSERVICE");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ISBILLABLE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REVUNDER)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SVID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SVNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLSYNCDETAIL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLSYNCDETAILS");

                entity.Property(e => e.DESTSTATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESTTABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOURCEDESCRIPTION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOURCESTATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOURCETABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SYNCID)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLSYNCLOGDETAIL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLSYNCLOGDETAILS");

                entity.Property(e => e.ACTIONTAKEN)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTIONOFITEM)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTIONOFITEM2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NAMEOFITEM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NAMEOFITEM2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SYNCID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRID2)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLSYNCMASTER>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLSYNCMASTER");

                entity.Property(e => e.ETIME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IPADDRESS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OFFLINEDATABASE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OFFLINEPASS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OFFLINESERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OFFLINEUSRID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEDATABASE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEPASS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINESERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ONLINEUSRID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STIME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SYNCDATE).HasColumnType("datetime");

                entity.Property(e => e.SYNCID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLSYNCSETTING>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLSYNCSETTINGS");

                entity.Property(e => e.OFFCONSTRING)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OFFDATABASE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OFFPASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OFFSERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OFFUSRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ONCONSTRING)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ONDATABASE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ONPASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ONSERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ONUSRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLTMIMAGE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLTMIMAGE");

                entity.Property(e => e.ALBUMNAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CATID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DATED).HasColumnType("datetime");

                entity.Property(e => e.DFLT)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IDNO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHOTO).HasColumnType("image");

                entity.Property(e => e.PICDESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PICID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PICNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PRNID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TAKENBY)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLUDEFINE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLUDEFINE");

                entity.Property(e => e.PL)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RE)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.bPrinter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.csh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.displayname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.mailfrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.mailpass)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.outgoingmailserver)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.pPrinter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.prcInv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.rPrinter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.rtnPrc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.rtnSls)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.slsInV)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLUSERACCESSLOG>(entity =>
            {
                entity.HasKey(e => e.ACSID);

                entity.ToTable("TBLUSERACCESSLOG");

                entity.Property(e => e.ACSID).ValueGeneratedNever();

                entity.Property(e => e.ACCFROM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ADATE).HasColumnType("datetime");

                entity.Property(e => e.AFTER)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ATIME)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BEFORE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ERRMSG)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ERRORNO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IPADD)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OPERATION)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPTION3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLUSERGROUP>(entity =>
            {
                entity.HasKey(e => e.GRPID);

                entity.ToTable("TBLUSERGROUP");

                entity.Property(e => e.GRPID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GRPNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLUSERGROUPPRIVELEGE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLUSERGROUPPRIVELEGE");

                entity.Property(e => e.CAT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FRMMENU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRMNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRMTITILE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GRP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GRPID)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ITM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.POPTION4)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.POPTION5)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PRVID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLUSERGROUPPRIVELEGETMP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLUSERGROUPPRIVELEGETMP");

                entity.Property(e => e.CAT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FRMMENU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRMNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FRMTITILE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GRP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GRPID)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ITM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.POPTION4)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.POPTION5)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PRVID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLUSERINFO>(entity =>
            {
                entity.HasKey(e => e.USRID)
                    .HasName("PK_TBLUSERINFO_1");

                entity.ToTable("TBLUSERINFO");

                entity.Property(e => e.USRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BDATE).HasColumnType("datetime");

                entity.Property(e => e.BID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CUSRID)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DEPARTMENT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DESIGNATION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DNSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GRPID)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.JDATE).HasColumnType("datetime");

                entity.Property(e => e.MOBILE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOTES)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPT1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPT2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OPT3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPT4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPT5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PASSWORD)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PHINT)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHOTO).HasColumnType("image");

                entity.Property(e => e.ROPT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOPT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UNAME)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.UPSTATUS)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UTYP)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLUSERREPORT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLUSERREPORTS");

                entity.Property(e => e.BID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DPT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REPORTS)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBLZONE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLZONE");

                entity.Property(e => e.BID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZFix)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ZID)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserInfo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
