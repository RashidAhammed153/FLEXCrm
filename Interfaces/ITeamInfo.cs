using FLEXCrm.Interfaces.BaseEntity;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Mvc;

namespace FLEXCrm.Interfaces
{
    public interface ITeamInfo : IBaseInterface<TBLCRMTEAM>
    {
        public List<TBLCRMTEAM> GetTeamInfoList();

        public TBLCRMTEAM GetTeamDetails(int id);
        public void AddTeamInfo(TBLCRMTEAM teamInfo);
        public void UpdateTeamInfo(TBLCRMTEAM teamInfo);
        public bool CheckTeamInfo(int id);
        public TBLCRMTEAM DeleteTeamInfo(int id);
    }
}


