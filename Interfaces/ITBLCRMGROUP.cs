using FLEXCrm.Interfaces.BaseEntity;
using FLEXCrm.Models;

namespace FLEXCrm.Interfaces
{
    public interface ITBLCRMGROUP : IBaseInterface<TBLCRMGROUP>
    {
        public List<TBLCRMGROUP> GetGroupInfoList();

        public TBLCRMGROUP GetGroupDetails(int id);
        public void AddGroupInfo(TBLCRMGROUP GroupInfo);
        public void UpdateGroupInfo(TBLCRMGROUP GroupInfo);
        public bool CheckGroupInfo(int id);
        public TBLCRMGROUP DeleteGroupInfo(int id);
    }
}
