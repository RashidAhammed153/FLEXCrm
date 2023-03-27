using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;

namespace FLEXCrm.Repositories
{
    public class TBLCRMTECHAMC_Repository : BaseRepository<TBLCRMTECHAMC>, ITBLCRMTECHAMC
    {
        public TBLCRMTECHAMC_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }
    }
}
