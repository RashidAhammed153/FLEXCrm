using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;

namespace FLEXCrm.Repositories
{
    public class TBLCRMCLIENT_Repository : BaseRepository<TBLCRMCLIENT>, ITBLCRMCLIENT
    {
        private readonly FLEXBDContext _context;
        public TBLCRMCLIENT_Repository(FLEXBDContext context) : base(context)
        {
            _context = context; 
        }

    }
}
