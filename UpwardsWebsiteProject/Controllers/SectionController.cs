using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using UpwardsWebsiteProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace UpwardsWebsiteProject.Controllers
{
    public class SectionController : Controller
    {
        // public IActionResult Index()
        //    {
        //        return View();
        //}
        private readonly ProjectDbContext _Db;
        public SectionController(ProjectDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult SectionList()
        {
            return View(_Db.tblSection.ToList());
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

        private void loadClass()
        {
            try
            {
                List<ClassEntity> ClassList = new List<ClassEntity>();
                ClassList = _Db.tblClass.ToList();

                ClassList.Insert(0, new ClassEntity { ClassId = 0, ClassName = "Please Select" });

                ViewBag.ClassList = ClassList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadSection()
        {
            try
            {
                List<SectionEntity> SectionList = new List<SectionEntity>();
                SectionList = _Db.tblSection.ToList();

                SectionList.Insert(0, new SectionEntity { SectionId = 0, SectionName = "Please Select" });

                ViewBag.SectionList = SectionList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadTeacher()
        {
            try
            {
                List<TeacherEntity> TeacherList = new List<TeacherEntity>();
                TeacherList = _Db.tblTeacher.ToList();

                TeacherList.Insert(0, new TeacherEntity { TeacherId = 0, Name = "Please Select" });

                ViewBag.TeacherList = TeacherList;

            }
            catch (Exception ex)
            {


            }
        }

        public async Task<IActionResult> AddSection(SectionEntity obj)
        {
            loadClass();
            loadSection();
            loadTeacher();
            loadBranch();
            loadSchool();
            return View(obj);
        }
        public async Task<IActionResult> SaveSection(SectionEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.SectionId == 0)
                    {
                        _Db.tblSection.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("SectionList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("SectionList");
            }
        }

        public async Task<IActionResult> DeleteSection(int SectionId)
        {
            try
            {
                var item = await _Db.tblSection.FindAsync(SectionId);

                if (item != null)
                {
                    object value = _Db.tblSection.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("SectionList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("SectionList");
            }
        }
    }
}
