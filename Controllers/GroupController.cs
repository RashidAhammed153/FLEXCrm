using FLEXCrm.DEMODATA;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FLEXCrm.Controllers
{
    [Authorize]
    [Route("api/group")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly ITBLCRMGROUP _tblcrmgroup;

        public GroupController(ITBLCRMGROUP tblcrmgroup)
        {
            _tblcrmgroup = tblcrmgroup;
        }



        [HttpGet]
        //CRM Group All Info
        public async Task<IActionResult> Index(string any)
        {
            var GroupList = await _tblcrmgroup.GetAll();
                GroupList = GroupList.OrderBy(x => Convert.ToInt16(x.CRGID)).ToList();
            
            return Ok(GroupList);
        }
        [HttpGet]
        public async Task<IActionResult> CreateCRMGroup(int id)
        {
            try
            {
                if (id != 0)
                {
                    var ExistGroup = await _tblcrmgroup.FindByIdAsync(id);

                    if (ExistGroup != null)
                    {
                        var Heading = "Edit Group";

                        return Ok(new {ExistGroup, Heading});
                    }
                }

                //ViewBag.Heading = "Create Group";
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return BadRequest();

        }
        [HttpPost]
        public async Task<IActionResult> CreateCRMGroup(TBLCRMGROUP model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var UserId = HttpContext.Session.GetString("UserID");

                    var ExistGroup =await _tblcrmgroup.FindByIdAsync(Convert.ToInt32(model.CRGID));
                    var Status = "";

                    if (ExistGroup == null)
                    {
                        var GroupIndex = _tblcrmgroup.GetAll().Result.OrderByDescending(x => x.CRGID).FirstOrDefault().CRGID;

                        if (GroupIndex == null)
                        {
                            GroupIndex = "1";
                        }

                        var NewGroup = new TBLCRMGROUP()
                        {
                            BID = "201",
                            CRGID = (Convert.ToInt32(GroupIndex) + 1).ToString(),
                            DESCRIPTION = model.DESCRIPTION,
                            CRGNAME = model.CRGNAME,
                            STATUS = model.STATUS,
                            UPSTATUS = "",
                            DNSTATUS = "NEW",
                            USRID = UserId,
                        };
                        await _tblcrmgroup.InsertByAsync(NewGroup);
                        Status = "created";
                    }
                    else
                    {
                        ExistGroup.DESCRIPTION = model.DESCRIPTION;
                        ExistGroup.CRGNAME = model.CRGNAME;
                        ExistGroup.STATUS = model.STATUS;
                        ExistGroup.USRID = UserId;
                        await _tblcrmgroup.Update(ExistGroup);
                        Status = "updated";
                    }

                    return Ok(new { any = Status });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return BadRequest();
        }
        public IActionResult DetailsCRMGroup(int id)
        {
            try
            {
                if (id != 0)
                {
                    var DetailsGroup = _tblcrmgroup.FindByIdAsync(id);

                    return Ok(DetailsGroup);
                }
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
            return Ok();

        }
        public IActionResult DeleteCRMGroup(int id)
        {
            try
            {
                if (id != 0)
                {
                    var SelectedGroup = _tblcrmgroup.FindByIdAsync(id);

                    if (SelectedGroup != null)
                    {
                        return Ok(SelectedGroup);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCRMGroup(TBLCRMGROUP model)
        {
            try
            {
                var DeletedGroup =await _tblcrmgroup.FindByIdAsync(Convert.ToInt32(model.CRGID));
                if (DeletedGroup != null)
                {
                    await _tblcrmgroup.Delete(DeletedGroup);
                    
                    var status = "deleted";
                    return Ok(new { any = status });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return BadRequest();
        }




        ////CRE Group Info

        public IActionResult CREIndex(string status)
        {
            var CREGroup = _tblcrmgroup.GetAll();
            //ViewBag.Status = status;
            return Ok(CREGroup);
        }
        [HttpGet]
        public async Task<IActionResult> CreateCREGroup(int id)
        {
            try
            {
                if (id != 0)
                {
                    var ExistGroup = await _tblcrmgroup.FindByIdAsync(id);
                    if (ExistGroup != null)
                    {
                        var Heading = "Edit Group";
                        return Ok(new { ExistGroup, Heading });
                    }
                }
                //ViewBag.Heading = "Create Group";
                return Ok(new { Heading = "Create Group" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return BadRequest();
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateCREGroup(TBLCRMGROUP model)
        //{

        //    try
        //    {
        //        //var UserId = HttpContext.Session.GetString("UserID");

        //        var ExistGroup = _tblcrmgroup.FindByIdAsync(Convert.ToInt32(model.CRGID));
        //        var Status = "";
        //        if (ModelState.IsValid)
        //        {
        //            if (ExistGroup == null)
        //            {
        //                var createNew = _tblcrmgroup.InsertByAsync(model);
        //                var GroupIndex = await _tblcrmgroup.GetAll();
        //                var Index = GroupIndex.OrderByDescending(x => x.CRGID).FirstOrDefault().CRGID;
        //                if (Index == null)
        //                {
        //                    Index = "1";
        //                }

        //                var NewGroup = new TBLCREGROUP()
        //                {
        //                    BID = "201",
        //                    CREID = (Convert.ToInt32(Index) + 1).ToString(),
        //                    DESCRIPTION = model.DESCRIPTION,
        //                    CRENAME = model.CRENAME,
        //                    STATUS = model.STATUS,
        //                    DNSTATUS = "NEW",
        //                };
        //                _.TBLCREGROUP.Add(NewGroup);
        //                Status = "created";
        //            }
        //            else
        //            {
        //                ExistGroup.DESCRIPTION = model.DESCRIPTION;
        //                ExistGroup.CRENAME = model.CRENAME;
        //                ExistGroup.STATUS = model.STATUS;
        //                ExistGroup.USRID = model.USRID;

        //                _context.TBLCREGROUP.Update(ExistGroup);
        //                Status = "updated";
        //            }

        //            _context.SaveChanges();
        //            return RedirectToAction("CREIndex", new { status = Status });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return View(ex);
        //    }

        //    return View();
        //}

        //public IActionResult DetailsCREGroup(int id)
        //{
        //    try
        //    {
        //        if (id != 0)
        //        {
        //            var DetailsGroup = _context.TBLCREGROUP.Where(x => x.CREID == id.ToString()).FirstOrDefault();
        //            return View(DetailsGroup);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return View(ex);
        //    }
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult DeleteCREGroup(int id)
        //{
        //    try
        //    {
        //        if (id != 0)
        //        {
        //            var SelectedGroup = _context.TBLCREGROUP.Where(x => x.CREID == id.ToString()).FirstOrDefault();

        //            if (SelectedGroup != null)
        //            {
        //                return View(SelectedGroup);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return View(ex);
        //    }
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult DeleteCREGroup(TBLCREGROUP model)
        //{
        //    try
        //    {
        //        var DeletedGroup = _context.TBLCREGROUP.Where(x => x.CREID == model.CREID).FirstOrDefault();
        //        if (DeletedGroup != null)
        //        {
        //            _context.TBLCREGROUP.Remove(DeletedGroup);

        //            _context.SaveChanges();


        //            return RedirectToAction("CREIndex", new { status = "deleted" });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return View(ex);
        //    }
        //    return View();
        //}
    }
}
