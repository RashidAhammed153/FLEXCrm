using FLEXCrm.Data;
using FLEXCrm.Interfaces.BaseEntity;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Mvc;

namespace FLEXCrm.Interfaces
{
    public interface ICRMTECHDETAIL : IBaseInterface<TBLCRMTECHDETAIL>
    {
        public List<TBLCRMTECHDETAIL> GetCRMTECHDETAILInfoList();

        public TBLCRMTECHDETAIL GetCRMTECHDETAILDetails(int id);
        public void AddCRMTECHDETAILInfo(TBLCRMTECHDETAIL CRMTECHDETAILInfo);
        public void UpdateCRMTECHDETAILInfo(TBLCRMTECHDETAIL CRMTECHDETAILInfo);
        public bool CheckCRMTECHDETAILInfo(int id);
        public TBLCRMTECHDETAIL DeleteCRMTECHDETAILInfo(int id);
    }
}
