using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{
   
    public class CRMTECHAMC_Repository : BaseRepository<TBLCRMTECHAMC>, ICRMTECHAMC
    {
        public CRMTECHAMC_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }

        public void AddCRMTECHAMCInfo(TBLCRMTECHAMC CRMTECHAMCInfo)
        {
            try
            {
                _flexbdContext.TBLCRMTECHAMC.Add(CRMTECHAMCInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckCRMTECHAMCInfo(int id)
        {
            return _flexbdContext.TBLCRMTECHAMC.Any(e => e.TMID == id.ToString());
        }

        public TBLCRMTECHAMC DeleteCRMTECHAMCInfo(int id)
        {
            try
            {
                TBLCRMTECHAMC? CRMTECHAMCInfo = _flexbdContext.TBLCRMTECHAMC.Find(id);

                if (CRMTECHAMCInfo != null)
                {
                    _flexbdContext.TBLCRMTECHAMC.Remove(CRMTECHAMCInfo);
                    _flexbdContext.SaveChanges();
                    return CRMTECHAMCInfo;
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

        public TBLCRMTECHAMC GetCRMTECHAMCDetails(int id)
        {
            try
            {
                TBLCRMTECHAMC? CRMTECHAMCInfo = _flexbdContext.TBLCRMTECHAMC.Find(id);
                if (CRMTECHAMCInfo != null)
                {
                    return CRMTECHAMCInfo;
                }
                else
                {
                    return CRMTECHAMCInfo;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<TBLCRMTECHAMC> GetCRMTECHAMCInfoList()
        {
            try
            {
                return _flexbdContext.TBLCRMTECHAMC.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateCRMTECHAMCInfo(TBLCRMTECHAMC CRMTECHAMCInfo)
        {
            try
            {
                _flexbdContext.Entry(CRMTECHAMCInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
