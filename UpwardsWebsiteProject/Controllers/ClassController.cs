using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace UpwardsWebsiteProject.Controllers
{
    public class ClassController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ProjectDbContext _Db;
        public ClassController(ProjectDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult ClassList()
        {
            return View(_Db.tblClass.ToList());
        }

        private void loadBranch()
        {
            try
            {
                List<BranchEntity> BranchList = new List<BranchEntity>();
                BranchList = _Db.tblBranch.ToList();

                BranchList.Insert(0, new BranchEntity { BranchId = 0, BranchName = "Please Select" });

                ViewBag.BranchList = BranchList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadSchool()
        {
            try
            {
                List<SchoolEntity> SchoolList = new List<SchoolEntity>();
                SchoolList = _Db.tblSchool.ToList();

                SchoolList.Insert(0, new SchoolEntity { SchoolId = 0, SchoolName = "Please Select" });

                ViewBag.SchoolList = SchoolList;

            }
            catch (Exception ex)
            {


            }
        }

        //private IActionResult View(object value)
        //{
        //    throw new NotImplementedException();
        //}


        public async Task<IActionResult> AddClass(ClassEntity obj)
        {   loadSchool();
            loadBranch();
            return View(obj);
        }
        public async Task<IActionResult> SaveClass(ClassEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.ClassId == 0)
                    {
                        _Db.tblClass.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("BranchList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("ClassList");
            }
        }

        public async Task<IActionResult> DeleteClass(int ClassId)
        {
            try
            {
                var item = await _Db.tblClass.FindAsync(ClassId)

;
                if (item != null)
                {
                    _Db.tblClass.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("ClassList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("ClassList");
            }
        }
    }
}
