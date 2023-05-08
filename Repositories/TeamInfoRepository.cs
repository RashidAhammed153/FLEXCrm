using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{
    public class TeamInfoRepository : BaseRepository<TBLCRMTEAM>, ITeamInfo
    {
        public TeamInfoRepository(FLEXBDContext flexbdContext) : base(flexbdContext)
        {
        }

        public void AddTeamInfo(TBLCRMTEAM teamInfo)
        {
            try
            {
                _flexbdContext.TBLCRMTEAM.Add(teamInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckTeamInfo(int id)
        {
            return _flexbdContext.TBLCRMTEAM.Any(e => e.EMPID == id.ToString());
        }

        public TBLCRMTEAM DeleteTeamInfo(int id)
        {
            try
            {
                TBLCRMTEAM? teamInfo = _flexbdContext.TBLCRMTEAM.Find(id);

                if (teamInfo != null)
                {
                    _flexbdContext.TBLCRMTEAM.Remove(teamInfo);
                    _flexbdContext.SaveChanges();
                    return teamInfo;
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

        public TBLCRMTEAM GetTeamDetails(int id)
        {
            try
            {
                TBLCRMTEAM? teamInfo = _flexbdContext.TBLCRMTEAM.Find(id);
                if (teamInfo != null)
                {
                    return teamInfo;
                }
                else
                {
                    return teamInfo;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<TBLCRMTEAM> GetTeamInfoList()
        {
            try
            {
                return _flexbdContext.TBLCRMTEAM.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateTeamInfo(TBLCRMTEAM teamInfo)
        {
            try
            {
                _flexbdContext.Entry(teamInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
