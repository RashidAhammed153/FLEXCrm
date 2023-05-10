using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{

    public class TBLCRMREGION_Repository : BaseRepository<TBLCRMREGION>, ITBLCRMREGION
    {
        public TBLCRMREGION_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }

        public void AddRegionInfo(TBLCRMREGION RegionInfo)
        {
            try
            {
                _flexbdContext.TBLCRMREGION.Add(RegionInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckRegionInfo(int id)
        {
            return _flexbdContext.TBLCRMREGION.Any(e => e.DIID == id.ToString());
        }

        public TBLCRMREGION DeleteRegionInfo(int id)
        {
            try
            {
                TBLCRMREGION? RegionInfo = _flexbdContext.TBLCRMREGION.Find(id);

                if (RegionInfo != null)
                {
                    _flexbdContext.TBLCRMREGION.Remove(RegionInfo);
                    _flexbdContext.SaveChanges();
                    return RegionInfo;
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

        public TBLCRMREGION GetRegionDetails(int id)
        {
            try
            {
                TBLCRMREGION? RegionInfo = _flexbdContext.TBLCRMREGION.Find(id);
                if (RegionInfo != null)
                {
                    return RegionInfo;
                }
                else
                {
                    return RegionInfo;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<TBLCRMREGION> GetRegionInfoList()
        {
            try
            {
                return _flexbdContext.TBLCRMREGION.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateRegionInfo(TBLCRMREGION RegionInfo)
        {
            try
            {
                _flexbdContext.Entry(RegionInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
