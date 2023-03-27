using FLEXCrm.Data;
using FLEXCrm.Models;
using FLEXCrm.Interfaces;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{
    public class CompanyInfoRepository : BaseRepository<TBLCOMINFO>,ICompanyInfo
    {

        public CompanyInfoRepository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {
        }
        //readonly FLEXBDContext _dbContext = new();

        //public CompanyInfoRepository(FLEXBDContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public List<TBLCOMINFO> GetCompanyInfoList()
        {
            try
            {
                return _flexbdContext.TBLCOMINFOs.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public TBLCOMINFO GetCompanyDetails(int id)
        {
            try
            {
                TBLCOMINFO? companyInfo = _flexbdContext.TBLCOMINFOs.Find(id);
                if (companyInfo != null)
                {
                    return companyInfo;
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

        public void AddCompanyInfo(TBLCOMINFO companyInfo)
        {
            try
            {
                _flexbdContext.TBLCOMINFOs.Add(companyInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateCompanyInfo(TBLCOMINFO companyInfo)
        {
            try
            {
                _flexbdContext.Entry(companyInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckCompanyInfo(int id)
        {
            return _flexbdContext.TBLCOMINFOs.Any(e => e.COMID == id);
        }

        public TBLCOMINFO DeleteCompanyInfo(int id)
        {
            try
            {
                TBLCOMINFO? companyInfo = _flexbdContext.TBLCOMINFOs.Find(id);

                if (companyInfo != null)
                {
                    _flexbdContext.TBLCOMINFOs.Remove(companyInfo);
                    _flexbdContext.SaveChanges();
                    return companyInfo;
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
    }
}
