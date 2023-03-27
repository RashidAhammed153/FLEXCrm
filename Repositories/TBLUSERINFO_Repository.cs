using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;

namespace FLEXCrm.Repositories
{
    public class TBLUSERINFO_Repository : BaseRepository<TBLUSERINFO>, ITBLUSERINFO
    {
        public TBLUSERINFO_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }
    }
}
