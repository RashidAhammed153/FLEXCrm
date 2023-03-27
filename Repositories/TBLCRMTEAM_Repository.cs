using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;

namespace FLEXCrm.Repositories
{
    public class TBLCRMTEAM_Repository : BaseRepository<TBLCRMTEAM>, ITBLCRMTEAM
    {
        public TBLCRMTEAM_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }
    }
}
