using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{
    public class CRMTECHDETAIL_Repository : BaseRepository<TBLCRMTECHDETAIL>, ICRMTECHDETAIL
    {
        public CRMTECHDETAIL_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }

        public void AddCRMTECHDETAILInfo(TBLCRMTECHDETAIL CRMTECHDETAILInfo)
        {
            try
            {
                _flexbdContext.TBLCRMTECHDETAIL.Add(CRMTECHDETAILInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckCRMTECHDETAILInfo(int id)
        {
            return _flexbdContext.TBLCRMTECHDETAIL.Any(e => e.TMID == id.ToString());
        }

        public TBLCRMTECHDETAIL DeleteCRMTECHDETAILInfo(int id)
        {
            try
            {
                TBLCRMTECHDETAIL? CRMTECHDETAILInfo = _flexbdContext.TBLCRMTECHDETAIL.Find(id);

                if (CRMTECHDETAILInfo != null)
                {
                    _flexbdContext.TBLCRMTECHDETAIL.Remove(CRMTECHDETAILInfo);
                    _flexbdContext.SaveChanges();
                    return CRMTECHDETAILInfo;
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

        public TBLCRMTECHDETAIL GetCRMTECHDETAILDetails(int id)
        {
            try
            {
                TBLCRMTECHDETAIL? CRMTECHDETAILInfo = _flexbdContext.TBLCRMTECHDETAIL.Find(id);
                if (CRMTECHDETAILInfo != null)
                {
                    return CRMTECHDETAILInfo;
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

        public List<TBLCRMTECHDETAIL> GetCRMTECHDETAILInfoList()
        {
            try
            {
                return _flexbdContext.TBLCRMTECHDETAIL.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateCRMTECHDETAILInfo(TBLCRMTECHDETAIL CRMTECHDETAILInfo)
        {
            try
            {
                _flexbdContext.Entry(CRMTECHDETAILInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
