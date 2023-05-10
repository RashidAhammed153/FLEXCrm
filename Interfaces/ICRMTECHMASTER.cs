using FLEXCrm.Models;
using FLEXCrm.Interfaces.BaseEntity;
using FLEXCrm.Data;

namespace FLEXCrm.Interfaces
{
    public interface ICRMTECHMASTER : IBaseInterface<TBLCRMTECHMASTER>
    {
        public List<TBLCRMTECHMASTER> GetTBLCRMTECHMASTERInfoList();

        public TBLCRMTECHMASTER GetTBLCRMTECHMASTERDetails(int id);
        public void AddTBLCRMTECHMASTERInfo(TBLCRMTECHMASTER TBLCRMTECHMASTERInfo);
        public void UpdateTBLCRMTECHMASTERInfo(TBLCRMTECHMASTER TBLCRMTECHMASTERInfo);
        public bool CheckTBLCRMTECHMASTERInfo(int id);
        public TBLCRMTECHMASTER DeleteTBLCRMTECHMASTERInfo(int id);
    }
}
