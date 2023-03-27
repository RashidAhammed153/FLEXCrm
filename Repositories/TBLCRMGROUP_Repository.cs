using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;

namespace FLEXCrm.Repositories
{
    public class TBLCRMGROUP_Repository : BaseRepository<TBLCRMGROUP>, ITBLCRMGROUP
    {
        public TBLCRMGROUP_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }
    }
}
