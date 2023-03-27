using FLEXCrm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using FLEXCrm.DEMODATA;

namespace FLEXCrm.Interfaces
{
    public interface IUser
    {
        public List<TBLCOMINFO> GetUserList();
    }
}
