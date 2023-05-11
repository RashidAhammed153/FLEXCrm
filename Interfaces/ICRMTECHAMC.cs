using FLEXCrm.Interfaces.BaseEntity;
using FLEXCrm.Models;

namespace FLEXCrm.Interfaces
{

    public interface ICRMTECHAMC : IBaseInterface<TBLCRMTECHAMC>
    {
        public List<TBLCRMTECHAMC> GetCRMTECHAMCInfoList();

        public TBLCRMTECHAMC GetCRMTECHAMCDetails(int id);
        public void AddCRMTECHAMCInfo(TBLCRMTECHAMC CRMTECHAMCInfo);
        public void UpdateCRMTECHAMCInfo(TBLCRMTECHAMC CRMTECHAMCInfo);
        public bool CheckCRMTECHAMCInfo(int id);
        public TBLCRMTECHAMC DeleteCRMTECHAMCInfo(int id);
    }
}
