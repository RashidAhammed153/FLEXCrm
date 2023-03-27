using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using System.Globalization;
using FLEXCrm.DEMODATA;
using FLEXCrm.Models;

namespace FLEXCrm.Repositories
{
    public class UserRepository : IUser
    {

        readonly FLEXBDContext _dbContext = new();

        public UserRepository(FLEXBDContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TBLCOMINFO> GetUserList()
        {
            try
            {
                return _dbContext.TBLCOMINFOs.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
