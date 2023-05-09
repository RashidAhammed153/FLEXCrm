using FLEXCrm.Data;
using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{
    public class CountryInfoRepository : BaseRepository<TBLCOUNTRY>, ICountryInfo
    {
        public CountryInfoRepository(FLEXBDContext flexbdContext) : base(flexbdContext)
        {
        }

        public void AddCountryInfo(TBLCOUNTRY CountryInfo)
        {
            try
            {
                _flexbdContext.TBLCOUNTRY.Add(CountryInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckCountryInfo(int id)
        {
            return _flexbdContext.TBLCOUNTRY.Any(e => e.CNID == id.ToString());
        }

        public TBLCOUNTRY DeleteCountryInfo(int id)
        {
            try
            {
                TBLCOUNTRY? CountryInfo = _flexbdContext.TBLCOUNTRY.Find(id);

                if (CountryInfo != null)
                {
                    _flexbdContext.TBLCOUNTRY.Remove(CountryInfo);
                    _flexbdContext.SaveChanges();
                    return CountryInfo;
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

        public TBLCOUNTRY GetCountryDetails(int id)
        {
            try
            {
                TBLCOUNTRY? CountryInfo = _flexbdContext.TBLCOUNTRY.Find(id);
                if (CountryInfo != null)
                {
                    return CountryInfo;
                }
                else
                {
                    return CountryInfo;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<TBLCOUNTRY> GetCountryInfoList()
        {
            try
            {
                return _flexbdContext.TBLCOUNTRY.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateCountryInfo(TBLCOUNTRY CountryInfo)
        {
            try
            {
                _flexbdContext.Entry(CountryInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
