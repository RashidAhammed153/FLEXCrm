using FLEXCrm.Data;
using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;

namespace FLEXCrm.Repositories
{
    public class TBLCITY_Repository : BaseRepository<TBLCITY>, ITBLCITY
    {

        public TBLCITY_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {
        }
    
    }
}
