using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{

    public class CRMTECHMASTER_Repository : BaseRepository<TBLCRMTECHMASTER>, ICRMTECHMASTER
    {
        public CRMTECHMASTER_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }

        public void AddTBLCRMTECHMASTERInfo(TBLCRMTECHMASTER TBLCRMTECHMASTERInfo)
        {
            try
            {
                _flexbdContext.TBLCRMTECHMASTER.Add(TBLCRMTECHMASTERInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckTBLCRMTECHMASTERInfo(int id)
        {
            return _flexbdContext.TBLCRMTECHMASTER.Any(e => e.TMID == id.ToString());
        }

        public TBLCRMTECHMASTER DeleteTBLCRMTECHMASTERInfo(int id)
        {
            try
            {
                TBLCRMTECHMASTER? TBLCRMTECHMASTERInfo = _flexbdContext.TBLCRMTECHMASTER.Find(id);

                if (TBLCRMTECHMASTERInfo != null)
                {
                    _flexbdContext.TBLCRMTECHMASTER.Remove(TBLCRMTECHMASTERInfo);
                    _flexbdContext.SaveChanges();
                    return TBLCRMTECHMASTERInfo;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public TBLCRMTECHMASTER GetTBLCRMTECHMASTERDetails(int id)
        {
            try
            {
                TBLCRMTECHMASTER? TBLCRMTECHMASTERInfo = _flexbdContext.TBLCRMTECHMASTER.Find(id);
                if (TBLCRMTECHMASTERInfo != null)
                {
                    return TBLCRMTECHMASTERInfo;
                }
                else
                {
                    return TBLCRMTECHMASTERInfo;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<TBLCRMTECHMASTER> GetTBLCRMTECHMASTERInfoList()
        {
            try
            {
                return _flexbdContext.TBLCRMTECHMASTER.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateTBLCRMTECHMASTERInfo(TBLCRMTECHMASTER TBLCRMTECHMASTERInfo)
        {
            try
            {
                _flexbdContext.Entry(TBLCRMTECHMASTERInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
