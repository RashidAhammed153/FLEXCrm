using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{

    public class TBLDIVISION_Repository : BaseRepository<TBLDIVISION>, ITBLDIVISION
    {
        public TBLDIVISION_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }

        public void AddDivisionInfo(TBLDIVISION DivisionInfo)
        {
            try
            {
                _flexbdContext.TBLDIVISION.Add(DivisionInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckDivisionInfo(int id)
        {
            return _flexbdContext.TBLDIVISION.Any(e => e.DIVID == id.ToString());
        }

        public TBLDIVISION DeleteDivisionInfo(int id)
        {
            try
            {
                TBLDIVISION? DivisionInfo = _flexbdContext.TBLDIVISION.Find(id);

                if (DivisionInfo != null)
                {
                    _flexbdContext.TBLDIVISION.Remove(DivisionInfo);
                    _flexbdContext.SaveChanges();
                    return DivisionInfo;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public TBLDIVISION GetDivisionDetails(int id)
        {
            try
            {
                TBLDIVISION? DivisionInfo = _flexbdContext.TBLDIVISION.Find(id);
                if (DivisionInfo != null)
                {
                    return DivisionInfo;
                }
                else
                {
                    return DivisionInfo;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<TBLDIVISION> GetDivisionInfoList()
        {
            try
            {
                return _flexbdContext.TBLDIVISION.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateDivisionInfo(TBLDIVISION DivisionInfo)
        {
            try
            {
                _flexbdContext.Entry(DivisionInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
