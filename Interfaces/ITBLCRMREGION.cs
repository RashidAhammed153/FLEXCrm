using FLEXCrm.Data;
using FLEXCrm.Interfaces.BaseEntity;
using FLEXCrm.Models;

namespace FLEXCrm.Interfaces
{
        public interface ITBLCRMREGION : IBaseInterface<TBLCRMREGION>
        {
            public List<TBLCRMREGION> GetRegionInfoList();

            public TBLCRMREGION GetRegionDetails(int id);
            public void AddRegionInfo(TBLCRMREGION RegionInfo);
            public void UpdateRegionInfo(TBLCRMREGION RegionInfo);
            public bool CheckRegionInfo(int id);
            public TBLCRMREGION DeleteRegionInfo(int id);
        }
    
}
