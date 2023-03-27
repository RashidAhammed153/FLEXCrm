using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;

namespace FLEXCrm.Repositories
{
    public class TBLDIVISION_Repository : BaseRepository<TBLDIVISION>, ITBLDIVISION
    {
        public TBLDIVISION_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }
    }
}
