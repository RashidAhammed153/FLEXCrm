using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces.BaseEntity;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Mvc;

namespace FLEXCrm.Interfaces
{
    public interface ICountryInfo : IBaseInterface<TBLCOUNTRY>
    {
        public List<TBLCOUNTRY> GetCountryInfoList();
        public TBLCOUNTRY GetCountryDetails(int id);
        public void AddCountryInfo(TBLCOUNTRY teamInfo);
        public void UpdateCountryInfo(TBLCOUNTRY teamInfo);
        public bool CheckCountryInfo(int id);
        public TBLCOUNTRY DeleteCountryInfo(int id);
    }
}
