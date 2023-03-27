using FLEXCrm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces.BaseEntity;

namespace FLEXCrm.Interfaces
{
    public interface ICompanyInfo:IBaseInterface<TBLCOMINFO>
    {
        public List<TBLCOMINFO> GetCompanyInfoList();

        public TBLCOMINFO GetCompanyDetails(int id);
        public void AddCompanyInfo(TBLCOMINFO companyInfo);
        public void UpdateCompanyInfo(TBLCOMINFO companyInfo);
        public bool CheckCompanyInfo(int id);
        public TBLCOMINFO DeleteCompanyInfo(int id);
    }
}
