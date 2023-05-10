using FLEXCrm.Data;
using FLEXCrm.Interfaces.BaseEntity;
using FLEXCrm.Models;

namespace FLEXCrm.Interfaces
{
    //public interface ITBLDIVISION : IBaseInterface<TBLDIVISION>
    //{

    //}

    public interface ITBLDIVISION : IBaseInterface<TBLDIVISION>
    {
        public List<TBLDIVISION> GetDivisionInfoList();

        public TBLDIVISION GetDivisionDetails(int id);
        public void AddDivisionInfo(TBLDIVISION DivisionInfo);
        public void UpdateDivisionInfo(TBLDIVISION DivisionInfo);
        public bool CheckDivisionInfo(int id);
        public TBLDIVISION DeleteDivisionInfo(int id);
    }
}
