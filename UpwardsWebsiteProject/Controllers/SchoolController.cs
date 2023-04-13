using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace UpwardsWebsiteProject.Controllers
{
    public class SchoolController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ProjectDbContext _Db;
        public SchoolController(ProjectDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult SchoolList()
        {
            return View(_Db.tblSchool.ToList());
        }

        //public IActionResult CreateSchool(SchoolEntity obj)
        //{
        //    return View(obj);
        //}

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

        public async Task<IActionResult> AddSchool(SchoolEntity obj)
        {
            loadSchool();
            return View(obj);
        }
        public async Task<IActionResult> SaveSchool(SchoolEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.SchoolId == 0)
                    {
                        _Db.tblSchool.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("SchoolList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("SchoolList");
            }
        }

        public async Task<IActionResult> DeleteSchool(int SchoolId)
        {
            try
            {
                var item = await _Db.tblSchool.FindAsync(SchoolId)

;
                if (item != null)
                {
                    object value = _Db.tblSchool.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("SchoolList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("SchoolList");
            }
        }
    }
}
