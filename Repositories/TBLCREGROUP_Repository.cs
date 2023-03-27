using FLEXCrm.Data;
using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces;
using FLEXCrm.Repositories.BaseRepository;

namespace FLEXCrm.Repositories
{
    public class TBLCREGROUP_Repository : BaseRepository<TBLCREGROUP>, ITBLCREGROUP
    {
        public TBLCREGROUP_Repository(FLEXBDContext flexbdContext) : base(flexbdContext)
        {
        }
    }
}
